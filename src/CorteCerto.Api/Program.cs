using CorrelationId;
using CorrelationId.DependencyInjection;
using CorteCerto.Api.Middlewares;
using CorteCerto.Api.RateLimiters;
using CorteCerto.CrossCutting.Extensions;
using CorteCerto.CrossCutting.Models;
using Scalar.AspNetCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var applicationSettings = builder.Configuration.GetApplicationSettings(builder.Environment);

builder.Services
    .AddSingleton<ISettings>(applicationSettings)
    .AddControllers();

builder.Services
    .AddProblemDetails()
    .AddExceptionHandler<GlobalExceptionHandler>()
    .AddRateLimiters()
    .AddDefaultCorrelationId()
    .AddEndpointsApiExplorer()
    .AddOpenApi()
    .AddDatabase(applicationSettings.PostgresSettings)
    .AddJwtSettings(applicationSettings.JwtSettings)
    .AddServices()
    .AddRepositories()
    .AddValidators()
    .AddMapper()
    .AddMediator();

builder.Host.UseSerilog((context, configuration) => 
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app
    .UseCorrelationId()
    .UseRateLimiter()
    .UseExceptionHandler()
    .UseSerilogRequestLogging()
    .UseHttpsRedirection()
    .UseAuthentication()
    .UseAuthorization();

app.MapControllers();

await app.RunAsync();
