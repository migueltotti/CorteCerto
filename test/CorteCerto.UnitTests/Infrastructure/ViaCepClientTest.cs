using CorteCerto.Domain.Interfaces.Gateways;
using CorteCerto.Infrastructure.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Infrastructure;

public class ViaCepClientTest
{
    private readonly HttpClient _httpClient;
    private readonly IViaCepClient _client;

    public ViaCepClientTest()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://viacep.com.br/ws/"),
        };
        _client = new ViaCepClient(_httpClient);
    }

    [Fact]
    public async Task GetAddressByZipCodeAsync_WithValidZipCode_ShouldReturnAddress()
    {
        // Arrange
        var validZipCode = "01001000"; // Example of a valid zip code, 8 numbers without hyphen

        // Act
        var result = await _client.GetAddressByCepAsync(validZipCode);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        Assert.Equal("Praça da Sé", result.Data.Street);
        Assert.Equal("Sé", result.Data.Neighborhood);
        Assert.Equal("São Paulo", result.Data.CityName);
        Assert.Equal("SP", result.Data.StateAcronym);
        Assert.Equal("São Paulo", result.Data.StateName);
    }

    [Fact]
    public async Task GetAddressByZipCodeAsync_WithInvalidValidZipCode_ShouldReturnError()
    {
        // Arrange
        var validZipCode = "99999999"; // Example of a invalid zip code

        // Act
        var result = await _client.GetAddressByCepAsync(validZipCode);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
        Assert.Equal("ViaCepGateway.InvalidZipCode", result.Error.Code);
    }

    [Fact]
    public async Task GetAddressByZipCodeAsync_WithWrongFormatZipCode_ShouldReturnError()
    {
        // Arrange
        var validZipCode = "123456789"; // Example of zip code with wrong format 9 digits instead of 8

        // Act
        var result = await _client.GetAddressByCepAsync(validZipCode);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
        Assert.Equal("ViaCepGateway.ServerError", result.Error.Code);
    }
}
