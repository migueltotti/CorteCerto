using CorteCerto.Application.DTO;
using CorteCerto.Domain.Entities;
using Mapster;

namespace CorteCerto.Application.Mappers
{
    public static class CustomMappers
    {
        public static void Configure()
        {
            TypeAdapterConfig<Address, AddressDto>
                .NewConfig()
                .Map(dest => dest.City, src => src.City.Name)
                .Map(dest => dest.State, src => src.City.State.Name)
                .Map(dest => dest.Country, src => src.City.State.Country.Name);
        }
    }
}
