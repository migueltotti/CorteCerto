using CorteCerto.Application.UseCases.Commands;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Gateways;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Application
{
    public class RegisterBarberProfileTest
    {
        private readonly IValidator<RegisterBarberProfileCommand> validator;
        private readonly CorteCertoDbContext dbContext;
        private readonly ICustomerRepository customerRepository;
        private readonly IBarberRepository barberRepository;
        private readonly IViaCepGateway viaCepGateway;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly ICityRepository cityRepository;
        private readonly IAddressRepository addressRepository;
        private readonly IAddressService addressService;
        private readonly ILogger<RegisterBarberProfileCommandHandler> logger;
        private readonly RegisterBarberProfileCommandHandler commandHandler;

        public RegisterBarberProfileTest()
        {
            validator = new RegisterBarberProfileCommandValidator();
            dbContext = new CorteCertoDbContext();
            customerRepository = new CustomerRepository(dbContext);
            barberRepository = new BarberRepository(dbContext);
            viaCepGateway = new ViaCepGateway();
            countryRepository = new CountryRepository(dbContext);
            stateRepository = new StateRepository(dbContext);
            cityRepository = new CityRepository(dbContext);
            addressRepository = new AddressRepository(dbContext);
            addressService = new AddressService(
                viaCepGateway,
                countryRepository,
                stateRepository,
                cityRepository,
                addressRepository);
            logger = NullLogger<RegisterBarberProfileCommandHandler>.Instance;
            commandHandler = new RegisterBarberProfileCommandHandler(
                validator,
                customerRepository,
                barberRepository,
                addressService,
                logger
            );
        }

        [Fact]
        public async Task RegisterBaberProfile_WithWrongBarberInfos_ShouldFail()
        {
            // Arrange
            var command = new RegisterBarberProfileCommand
            (
                Guid.NewGuid(),
                "", // Invalid description
                null,
                "12345-678",
                100
            );

            // Act
            var result = await commandHandler.HandleAsync(command);

            // Assert
            Assert.True(result.IsFailure);
            Assert.Equal("CustomerError.ValidationError", result.Error.Code);
        }

        [Fact]
        public async Task RegisterBaberProfile_WithInvalidPersonId_ShouldFail()
        {
            // Arrange
            var command = new RegisterBarberProfileCommand
            (
                Guid.NewGuid(),
                "Teste Cep inválido", // Invalid description
                null,
                "12345-678",
                100
            );

            // Act
            var result = await commandHandler.HandleAsync(command);

            // Assert
            Assert.True(result.IsFailure);
            Assert.Equal("CustomerError.NotFoundById", result.Error.Code);
        }

        [Fact]
        public async Task RegisterBaberProfile_WithInvalidCep_ShouldFail()
        {
            // Arrange
            var command = new RegisterBarberProfileCommand
            (
                Guid.Parse("fceceaf7-2d08-44f7-8752-a5b39ba820ed"),
                "Teste Cep inválido", // Invalid description
                null,
                "12345-678",
                100
            );

            // Act
            var result = await commandHandler.HandleAsync(command);

            // Assert
            Assert.True(result.IsFailure);
            Assert.Equal("ViaCepGateway.InvalidZipCode", result.Error.Code);
        }

        [Fact]
        public async Task RegisterBaberProfile_WithValidInfos_ShouldBeSuccess()
        {
            // Arrange
            var command = new RegisterBarberProfileCommand
            (
                Guid.Parse("fceceaf7-2d08-44f7-8752-a5b39ba820ed"),
                "Teste dados válidos",
                null,
                "01001-000",
                8080
            );

            // Act
            var result = await commandHandler.HandleAsync(command);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(Guid.Parse("fceceaf7-2d08-44f7-8752-a5b39ba820ed"), result.Data.Id);
        }
    }
}
