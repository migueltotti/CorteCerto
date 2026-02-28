using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Entities;

public class Country : BaseEntity<int>
{
    public string Name { get; private set; }
    public List<State>? States { get; private set; }
        
    public Country(string name)
    {
        Name = name;
        States = [];
    }

    private Country() { }
}
