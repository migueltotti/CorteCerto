using CorteCerto.Domain.Base;
using CorteCerto.Domain.Errors;

namespace CorteCerto.Domain.Entities;

public abstract class Person : BaseEntity<Guid>
{
    public string Name { get; protected set; }
    public string Email { get; protected set; }
    public string PhoneNumber { get; protected set; }
    public string PasswordHash { get; protected set; }
    private const int PasswordHashLenght = 97;

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

    public void UpadteEmail(string email)
    {
        Email = email;
    }

    public Result UpadtePasswordHash(string passwordHash)
    {
        if (!passwordHash.Contains("-") || passwordHash.Length != PasswordHashLenght)
            return Result.Failure(PersonErrors.InvalidPasswordHashFormat);

        PasswordHash = passwordHash;

        return Result.Success();
    }

    public bool IsCurrentEmail(string email)
    {
        return Email.Equals(email, StringComparison.Ordinal);
    }
}
