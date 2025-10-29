﻿using CorteCerto.Domain.Base;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Domain.ValueObjects;
using CorteCerto.Infrastructure.DTO;
using System.Net.Http.Json;
using System.Text.Json;

namespace CorteCerto.Infrastructure.Gateways;

public class ViaCepGateway : IViaCepGateway, IDisposable
{
    private readonly HttpClient _httpClient;

    public ViaCepGateway()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://viacep.com.br/ws/")
        };
    }

    public async Task<Result<AddressLookupResult>> GetAddressByZipCodeAsync(string zipCode)
    {
        var response = await _httpClient.GetAsync($"{zipCode}/json/");

        if (!response.IsSuccessStatusCode)
        {
            return Result<AddressLookupResult>.Failure(new Error("ViaCepGateway.ServerError", "Failed to comunicate with ViaCep."));
        }

        var viaCepResponse = await response.Content.ReadFromJsonAsync<ViaCepResponse>(new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        if (viaCepResponse is not null && !viaCepResponse.IsValid())
        {
            return Result<AddressLookupResult>.Failure(new Error("ViaCepGateway.InvalidZipCode", "The provided zip code is invalid."));
        }

        return Result<AddressLookupResult>.Success(
            new AddressLookupResult
            (
                viaCepResponse.Logradouro!,
                viaCepResponse.Bairro!,
                viaCepResponse.Localidade!,
                viaCepResponse.Uf!,
                viaCepResponse.Estado!
            ));
    }

    public void Dispose() => _httpClient.Dispose();
}
