using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Helpers;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;

namespace CorteCerto.Domain.Services;

public class AddressService(
    IViaCepGateway viaCepGateway,
    ICountryRepository countryRepository,
    IStateRepository stateRepository,
    ICityRepository cityRepository,
    IAddressRepository addressRepository) : IAddressService
{
    public async Task<Result<Address>> CreateAddressByCep(string cep, int number)
    {
        var addressExists = await addressRepository.GetAddressWithCityByZipCode(cep.RemoveHifen());

        Address address;

        if(addressExists is not null)
        {
            address = new Address(
                addressExists.Street,
                number,
                addressExists.Neighborhood,
                addressExists.ZipCode,
                addressExists.City);

            cityRepository.AttachObject(addressExists.City);

            addressRepository.Insert(address);

            return Result<Address>.Success(address);
        }

        var addressLookuResult = await viaCepGateway.GetAddressByCepAsync(cep.RemoveHifen());

        if (addressLookuResult.IsFailure)
            return Result<Address>.Failure(addressLookuResult.Error);

        var country = await GetOrCreateBrazilCountry();

        var state = await GetOrCreateStateByAcronym(
            addressLookuResult.Data.StateAcronym,
            addressLookuResult.Data.StateName,
            country);

        var city = await GetOrCreateCityByState(
            addressLookuResult.Data.CityName,
            state);

        address = new Address(
            addressLookuResult.Data.Street,
            number,
            addressLookuResult.Data.Neighborhood,
            cep.RemoveHifen(),
            city);

        cityRepository.AttachObject(city);

        addressRepository.Insert(address);

        return Result<Address>.Success(address);
    }

    private async Task<Country> GetOrCreateBrazilCountry()
    {
        var country = await countryRepository.GetCountryByName("Brasil");

        if (country is null)
        {
            country = new Country("Brasil");

            countryRepository.Insert(country);
        }

        return country;
    }

    private async Task<State> GetOrCreateStateByAcronym(string stateAcronym, string name, Country country)
    {
        var state = await stateRepository.GeyStateByAcronym(stateAcronym);

        if (state is null)
        {
            state = new State(name, stateAcronym, country);

            stateRepository.Insert(state);
        }

        return state;
    }

    private async Task<City> GetOrCreateCityByState(string cityName, State state)
    {
        var city = await cityRepository.GetCityByNameAndStateAcronym(cityName, state.Acronym);

        if (city is null)
        {
            city = new City(cityName, state);

            cityRepository.Insert(city);
        }

        return city;
    }
}
