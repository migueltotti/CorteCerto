using CorteCerto.Application.UseCases.Queries.Barbers;
using CorteCerto.Application.UseCases.Queries.People;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.UnitTests.Application;

public class GetServiceTest
{
    private readonly ServiceProvider provider;
    private readonly GetServicesQueryHandler queryHandler;

    public GetServiceTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        queryHandler = new GetServicesQueryHandler(
            provider.GetRequiredService<IServiceRepository>()
        );
    }

    [Fact]
    public async Task GetServices_WithoutFilter_ShouldReturnAllServices()
    {
        // Arrange
        var query = new GetServicesQuery(
            null,
            null,
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetServices_WithPaginationFilter_ShouldReturnPagedServiceCollection()
    {
        // Arrange
        var query = new GetServicesQuery(
            null,
            null,
            null,
            PageSize: 2,
            PageNumber: 1
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(11, result.TotalCount);
        Assert.Equal(6, result.TotalPages);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(2, result.PageSize);
    }

    [Fact]
    public async Task GetServices_WithNameFilter_ShouldReturnPagedServiceCollectionBasedOnProvidedName()
    {
        // Arrange
        var query = new GetServicesQuery(
            "Teste",
            null,
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(2, result.TotalCount);
        Assert.Equal(1, result.TotalPages);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetServices_WithPriceFilter_ShouldReturnPagedServiceCollectionBasedOnProvidedPrice()
    {
        // Arrange
        var query = new GetServicesQuery(
            null,
            null,
            Price: 45,
            PriceOperator: PriceOperator.GreaterThan
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(3, result.TotalCount);
        Assert.Equal(1, result.TotalPages);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetServices_WithDurationFilter_ShouldReturnPagedServiceCollectionBasedOnProvidedDuration()
    {
        // Arrange
        var query = new GetServicesQuery(
            null,
            Duration: TimeSpan.FromHours(1),
            null,
            DurationOperator: DurationOperator.LessThan
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(1, result.TotalCount);
        Assert.Equal(1, result.TotalPages);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }
}
