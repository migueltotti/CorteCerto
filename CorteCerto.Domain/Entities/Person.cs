using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public abstract class Person : BaseEntity<Guid>
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Password { get; private set; }
    public List<Role> Roles { get; private set; }

    protected Person()
    {
    }

    protected Person(Guid id, string name, string email, string phoneNumber, string password, List<Role> roles) : base(id)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Password = password;
        Roles = roles;
    }
}
