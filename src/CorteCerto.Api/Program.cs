using CorteCerto.CrossCutting.Extensions;
using CorteCerto.CrossCutting.Models;

var builder = WebApplication.CreateBuilder(args);

var applicationSettings = builder.Configuration.GetApplicationSettings(builder.Environment);

builder.Services
    .AddSingleton<ISettings>(applicationSettings)
    .AddControllers();

builder.Services
    .AddDatabase(applicationSettings.PostgresSettings)
    .AddJwtSettings(applicationSettings.JwtSettings)
    .AddServices()
    .AddRepositories()
    .AddValidators()
    .AddMediator();

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app
    .UseHttpsRedirection()
    .UseAuthorization();

app.MapControllers();

await app.RunAsync();
