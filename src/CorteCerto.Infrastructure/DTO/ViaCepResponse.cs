using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CorteCerto.Infrastructure.DTO;

internal sealed class ViaCepResponse
{
    [JsonPropertyName("Cep")]
    public string? Zip { get; set; }
    
    [JsonPropertyName("Logradouro")]
    public string? PublicPlace { get; set; }
    
    [JsonPropertyName("Complemento")]
    public string? Complement { get; set; }
    
    [JsonPropertyName("Unidade")]
    public string? Unity { get; set; }
    
    [JsonPropertyName("Bairro")]
    public string? District { get; set; }
    
    [JsonPropertyName("Localidade")]
    public string? Location { get; set; }
    
    [JsonPropertyName("Uf")]
    public string? Uf { get; set; }
    
    [JsonPropertyName("Estado")]
    public string? State { get; set; }
    
    [JsonPropertyName("Regiao")]
    public string? Region { get; set; }
    
    [JsonPropertyName("Ibge")]
    public string? Ibge { get; set; }
    
    [JsonPropertyName("Gia")]
    public string? Gia { get; set; }
    
    [JsonPropertyName("DDD")]
    public string? DDD { get; set; }
    
    [JsonPropertyName("Siafi")]
    public string? Siafi { get; set; }
    
    [JsonPropertyName("Erro")]
    public string? Error { get; set; }

    public bool IsValid() => Error is null || Boolean.Parse(Error) == false;
}
