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

        TypeAdapterConfig<Customer, AppointmentCustomerDto>
            .NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name);
        
        TypeAdapterConfig<Barber, AppointmentBarberDto>
            .NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.Address, src => src.Address);
        
        TypeAdapterConfig<Service, AppointmentServiceDto>
            .NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.Price, src => src.Price)
            .Map(dest => dest.Duration, src => src.Duration);
        
        return services;
    }
}