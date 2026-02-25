using System.Net.Http.Json;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Interfaces.Gateways;
using CorteCerto.Domain.Responses;
using CorteCerto.Infrastructure.DTO;

namespace CorteCerto.Infrastructure.Gateways;

public class ViaCepClient(HttpClient httpClient) : IViaCepClient
{
    public async Task<Result<AddressLookupResult>> GetAddressByCepAsync(string zipCode)
    {
        var response = await httpClient.GetAsync($"{zipCode}/json/");

        if (!response.IsSuccessStatusCode)
        {
            return Result<AddressLookupResult>.Failure(new Error("ViaCepGateway.ServerError", "Failed to comunicate with ViaCep."));
        }

        var viaCepResponse = await response.Content.ReadFromJsonAsync<ViaCepResponse>();

        if (viaCepResponse is not null && !viaCepResponse.IsValid())
        {
            return Result<AddressLookupResult>.Failure(new Error("ViaCepGateway.InvalidZipCode", "The provided zip code is invalid."));
        }

        return Result<AddressLookupResult>.Success(
            new AddressLookupResult
            (
                viaCepResponse?.PublicPlace!,
                viaCepResponse?.District!,
                viaCepResponse?.Location!,
                viaCepResponse?.Uf!,
                viaCepResponse?.State!
            ));
    }
}
