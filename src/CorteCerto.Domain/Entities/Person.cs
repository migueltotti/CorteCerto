using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Entities;

public abstract class Person : BaseEntity<Guid>
{
    public string Name { get; protected set; }
    public string Email { get; protected set; }
    public string PhoneNumber { get; protected set; }
    public string PasswordHash { get; protected set; }

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

    public bool IsCurrentEmail(string email)
    {
        return Email.Equals(email, StringComparison.Ordinal);
    }
}
