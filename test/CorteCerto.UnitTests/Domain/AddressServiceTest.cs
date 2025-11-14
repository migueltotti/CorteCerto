using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Gateways;
using CorteCerto.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Domain;

public class AddressServiceTest
{
    private readonly ServiceProvider provider;
    private readonly IAddressService addressService;

    public AddressServiceTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IViaCepGateway, ViaCepGateway>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IStateRepository, StateRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IAddressService, AddressService>();

        provider = services.BuildServiceProvider();

        addressService = provider.GetRequiredService<IAddressService>();
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
