using CorrelationId;
using CorrelationId.DependencyInjection;
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
    .AddEndpointsApiExplorer()
    .AddOpenApi();

builder.Host.UseSerilog((context, configuration) => 
    configuration.ReadFrom.Configuration(context.Configuration));

builder.Services
    .AddDefaultCorrelationId()
    .AddDatabase(applicationSettings.PostgresSettings)
    .AddJwtSettings(applicationSettings.JwtSettings)
    .AddServices()
    .AddRepositories()
    .AddValidators()
    .AddMapper()
    .AddMediator();

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app
    .UseCorrelationId()
    .UseSerilogRequestLogging()
    .UseHttpsRedirection()
    .UseAuthorization();

app.MapControllers();

await app.RunAsync();
