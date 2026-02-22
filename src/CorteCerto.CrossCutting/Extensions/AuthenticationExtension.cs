using System.Text;
using CorteCerto.Infrastructure.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CorteCerto.CrossCutting.Extensions;

public static class AuthenticationExtension
{
    public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, JwtSettings jwtSettings)
    {
        services.AddJwtSettings(jwtSettings);

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.SaveToken = true;
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ClockSkew = TimeSpan.Zero,
                ValidAudience = jwtSettings.Audience,
                ValidIssuer = jwtSettings.Issuer,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
            };
        });

        return services;
    }
    
    private static IServiceCollection AddJwtSettings(this IServiceCollection services, JwtSettings settings)
    {
        services.AddSingleton<IOptions<JwtSettings>>(Options.Create(settings));
        
        return services;
    }
}