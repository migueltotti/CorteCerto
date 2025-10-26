using CorteCerto.Domain.Base;
using System.Text;

namespace CorteCerto.Domain.Entities;

public class Role : BaseEntity<int>
{
    public string Name { get; private set; }
    public List<Person> Peoples { get; private set; }

    public Role()
    {
    }

    public Role(int id, string name) : base(id)
    {
        Name = name;
    }
}
