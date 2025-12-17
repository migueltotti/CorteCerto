using CorteCerto.Application.Requests;
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
            new GetAppointmentsRequest()
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
            new GetAppointmentsRequest(Ids: [Guid.Parse("4e14d509-25e0-453b-8d96-7a717c39aed6")])
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
            new GetAppointmentsRequest(CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"))
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
            new GetAppointmentsRequest(BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"))
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
            new GetAppointmentsRequest(ServiceId: 11)
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
            new GetAppointmentsRequest(CustomerName: "Teste")
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
            new GetAppointmentsRequest(BarberName: "Miguel")
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
            new GetAppointmentsRequest(BarberName: "Cabelo e Barba Pelo Root Agregate")
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
            new GetAppointmentsRequest(AppointmentStatus: AppointmentStatus.Canceled)
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
           new GetAppointmentsRequest(
               InitialDate: DateTime.UtcNow.AddDays(-10),
               FinalDate: DateTime.UtcNow.AddDays(10)
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
    public async Task GetAppointments_WithPaginationFilter_ShouldReturnPagedAppointmentsCollection()
    {
        // Arrange
        var query = new GetAppointmentsQuery(
            new GetAppointmentsRequest(
                PageSize: 2,
                PageNumber: 1
            )
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