using CorteCerto.Application.DTO;
using CorteCerto.Domain.Entities;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class MapperExtension
{
    public static IServiceCollection AddMapper(this IServiceCollection services)
    {
        TypeAdapterConfig<Address, AddressDto>
            .NewConfig()
            .Map(dest => dest.City, src => src.City.Name)
            .Map(dest => dest.State, src => src.City.State.Name)
            .Map(dest => dest.StateAcronym, src => src.City.State.Acronym)
            .Map(dest => dest.Country, src => src.City.State.Country.Name);
        
        return services;
    }
}