using CorteCerto.Application.UseCases.Queries.Barbers;
using CorteCerto.Application.UseCases.Queries.Customers;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.UnitTests.Application;

public class GetCustomersTest
{
    private readonly ServiceProvider provider;
    private readonly GetCustomersQueryHandler queryHandler;


    public GetCustomersTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        queryHandler = new GetCustomersQueryHandler(
            provider.GetRequiredService<ICustomerRepository>()
        );
    }

    [Fact]
    public async Task GetCustomer_WithoutFilters_ShouldReturnPagedCustomersCollection()
    {
        // Arrange
        var query = new GetCustomersQuery(
            null,
            null,
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetCustomer_WithIdFilter_ShouldReturnFilteredPagedCustomersCollection()
    {
        // Arrange
        var query = new GetCustomersQuery(
            Guid.Parse("6bad02d7-b8bf-41bd-bb05-0f58369facf1"),
            null,
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Single(result);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetCustomer_WithNameFilter_ShouldReturnFilteredPagedCustomersCollection()
    {
        // Arrange
        var query = new GetCustomersQuery(
            null,
            "Teste da Silva",
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetCustomer_WithEmailFilter_ShouldReturnFilteredPagedCustomersCollection()
    {
        // Arrange
        var query = new GetCustomersQuery(
            null,
            null,
            "teste@silva.com"
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Single(result);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }
}
