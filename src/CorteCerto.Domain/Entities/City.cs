using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class City : BaseEntity<int>
{
    public string Acronym { get; private set; }
    public string Name { get; private set; }
    public List<Address> Addresses{ get; private set; }
    public State State { get; private set; }

    public City(string name, State state, string acronym)
    {
        Name = name;
        State = state;
        Addresses = [];
        Acronym = acronym;
    }

    private City() { }
}
