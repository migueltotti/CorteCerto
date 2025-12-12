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
    .AddValidation()
    .AddMediator();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app
    .UseHttpsRedirection()
    .UseAuthorization();

app.MapControllers();

await app.RunAsync();
