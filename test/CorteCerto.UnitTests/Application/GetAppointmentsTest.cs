using CorteCerto.Application.UseCases.Queries.Barbers;
using CorteCerto.Application.UseCases.Queries.People;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Enums;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.UnitTests.Application;

public class GetAppointmentsTest
{
    private readonly ServiceProvider provider;
    private readonly GetAppointmentsQueryHandler queryHandler;

    public GetAppointmentsTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        queryHandler = new GetAppointmentsQueryHandler(
            provider.GetRequiredService<IAppointmentRepository>()
        );
    }

    [Fact]
    public async Task GetAppointments_WithoutFilters_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
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
    public async Task GetAppointments_WithIdFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            Guid.Parse("4e14d509-25e0-453b-8d96-7a717c39aed6"),
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null
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
    public async Task GetAppointments_WithCustomerIdFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null
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
    public async Task GetAppointments_WithBarberIdFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            null,
            null,
            null,
            null,
            null,
            null,
            null
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
    public async Task GetAppointments_WithServiceIdFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            11,
            null,
            null,
            null,
            null,
            null,
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(2, result.Results.Count());
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetAppointments_WithCustomerNameFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            null,
            "Teste",
            null,
            null,
            null,
            null,
            null
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
    public async Task GetAppointments_WithBarberNameFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            null,
            null,
            "Miguel",
            null,
            null,
            null,
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.Empty(result.Results);
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetAppointments_WithServiceNameFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            null,
            null,
            null,
            "Cabelo e Barba Pelo Root Agregate",
            null,
            null,
            null
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(2, result.Results.Count());
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(50, result.PageSize);
    }

    [Fact]
    public async Task GetAppointments_WithAppointmentStatusFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            AppointmentStatus.Canceled,
            null,
            null
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
    public async Task GetAppointments_WithDateFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            DateTime.UtcNow.AddDays(-10),
            DateTime.UtcNow.AddDays(10)
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
    public async Task GetAppointments_WithPaginationFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            2,
            1
        );

        // Act
        var result = await queryHandler.HandleAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Results);
        Assert.Equal(2, result.Results.Count());
        Assert.Equal(1, result.PageNumber);
        Assert.Equal(2, result.PageSize);
        Assert.Equal(2, result.TotalPages);
        Assert.Equal(3, result.TotalCount);
    }
}