using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;

namespace CorteCerto.UnitTests
{
    public class CustomerTest
    {
        private readonly CorteCertoDbContext context = new CorteCertoDbContext();
        private readonly ICustomerRepository repository;

        public CustomerTest()
        {
            repository = new CustomerRepository(context);
        }


        [Fact]
        public void CreateCustomer_WithUniqueValues_ShouldBeSuccess()
        {
            // Arrange
            var newRole = new Role("Customer");

            var newCustomer = new Customer(
                Guid.NewGuid(),
                "Teste da Silva",
                "teste@silva.com",
                "18997872005",
                "Teste@Silva10",
                [newRole]
            );

            // Act
            repository.Insert(newCustomer);

            // Assert
            var createdCustomer = repository.Select(newCustomer.Id);

            Assert.NotNull(createdCustomer);
        }
    }
}