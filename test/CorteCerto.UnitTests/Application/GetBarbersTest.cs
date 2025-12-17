using CorteCerto.Application.Requests;
using CorteCerto.Application.UseCases.Queries.Barbers;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.UnitTests.Application;

public class GetBarbersTest
{
    private readonly ServiceProvider provider;
    private readonly GetBarbersQueryHandler queryHandler;

    public GetBarbersTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        queryHandler = new GetBarbersQueryHandler(
            provider.GetRequiredService<IBarberRepository>()
        );
    }

    [Fact]
    public async Task GetBarber_WithoutFilters_ShouldReturnPagedBarbersCollection()
    {
        // Arrange
        var query = new GetBarbersQuery(new GetPeopleRequest());

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetBarber_WithPaginationFilter_ShouldReturnPagedBarbersCollection()
    {
        // Arrange
        var query = new GetBarbersQuery(
            new GetPeopleRequest(
                PageSize: 2,
                PageNumber: 1
            )
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(3, result.TotalCount);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(2, result.PageSize);
    }

    [Fact]
    public async Task GetBarber_WithIdFilter_ShouldReturnFilteredPagedBarbersCollection()
    {
        // Arrange
        var query = new GetBarbersQuery(
            new GetPeopleRequest(
                Ids: [Guid.Parse("6bad02d7-b8bf-41bd-bb05-0f58369facf1")]
            )
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Single(result.Results);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetBarber_WithNameFilter_ShouldReturnFilteredPagedBarbersCollection()
    {
        // Arrange
        var query = new GetBarbersQuery(
            new GetPeopleRequest(
                Name: "Teste da Silva"
            )
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(3, result.Results.Count());
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetBarber_WithEmailFilter_ShouldReturnFilteredPagedBarbersCollection()
    {
        // Arrange
        var query = new GetBarbersQuery(
            new GetPeopleRequest(
                Email: "teste@silva.com"
            )
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Single(result.Results);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }
}
