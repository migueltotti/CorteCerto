using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;

namespace CorteCerto.Domain.Entities;

public abstract class Person : BaseEntity<Guid>
{
    public string Name { get; protected set; }
    public string Email { get; protected set; }
    public string PhoneNumber { get; protected set; }
    public string PasswordHash { get; protected set; }
    public string? RefreshToken { get; private set; }
    public DateTime? RefreshTokenExpiresAt { get; private set; }

    private const int PasswordHashLength = 97;

    protected Person()
    {
    }

    protected Person(Guid id, string name, string email, string phoneNumber, string passwordHash) : base(id)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        PasswordHash = passwordHash;
    }

    public void UpdateEmail(string email)
    {
        Email = email;
    }

    public Result UpdatePasswordHash(string passwordHash)
    {
        if (!passwordHash.Contains("-") || passwordHash.Length != PasswordHashLength)
            return Result.Failure(PersonErrors.InvalidPasswordHashFormat);

        PasswordHash = passwordHash;

        return Result.Success();
    }

    public bool IsCurrentEmail(string email)
    {
        return Email.Equals(email, StringComparison.Ordinal);
    }

    public void SetRefreshToken(string refreshToken, int expirationTimeInMinutes)
    {
        RefreshToken = refreshToken;
        RefreshTokenExpiresAt = DateTime.UtcNow.AddMinutes(expirationTimeInMinutes);
    }

    public void RemoveRefreshToken()
    {
        RefreshToken = "";
    }
}
