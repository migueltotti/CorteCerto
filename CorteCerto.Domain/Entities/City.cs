using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class City : BaseEntity<int>
{
    public string Name { get; private set; }
    public List<Address> Addresses{ get; private set; }
    public State State { get; private set; }

    public City(string name, State state)
    {
        Name = name;
        State = state;
        Addresses = [];
    }

    private City() { }
}
