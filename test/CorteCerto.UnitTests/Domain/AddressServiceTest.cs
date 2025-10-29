using CorteCerto.Domain.Interfaces;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Gateways;
using CorteCerto.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Domain;

public class AddressServiceTest
{
    private readonly CorteCertoDbContext context;
    private readonly IViaCepGateway viaCepGateway;
    private readonly ICountryRepository countryRepository;
    private readonly IStateRepository stateRepository;
    private readonly ICityRepository cityRepository;
    private readonly IAddressRepository addressRepository;
    private readonly IAddressService addressService;

    public AddressServiceTest()
    {
        context = new CorteCertoDbContext();
        viaCepGateway = new ViaCepGateway();
        countryRepository = new CountryRepository(context);
        stateRepository = new StateRepository(context);
        cityRepository = new CityRepository(context);
        addressRepository = new AddressRepository(context);
        addressService = new AddressService(
            viaCepGateway,
            countryRepository,
            stateRepository,
            cityRepository,
            addressRepository);
    }

    [Fact]
    public async Task CreateAddress_WithValidCep_ShouldbeSuccess()
    {
        // Arrange
        var cep = "01001000";

        // Act
        var addressResult = await addressService.CreateAddressByCep(cep, 100);

        // Assert
        Assert.True(addressResult.IsSuccess);
        Assert.Equal(cep, addressResult.Data.ZipCode);
        Assert.Equal(100, addressResult.Data.Number);
        Assert.Equal("São Paulo", addressResult.Data.City.Name);
        Assert.Equal("SP", addressResult.Data.City.State.Acronym);
        Assert.Equal("Brasil", addressResult.Data.City.State.Country.Name);
    } 
}
