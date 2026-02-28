using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Entities;

public class City : BaseEntity<int>
{
    public string Name { get; private set; }
    public List<Address>? Addresses{ get; private set; }
    public int StateId { get; private set; }
    public State? State { get; private set; }

    public City(string name, int stateId)
    {
        Name = name;
        StateId = stateId;
        Addresses = [];
    }

    private City() { }
}
