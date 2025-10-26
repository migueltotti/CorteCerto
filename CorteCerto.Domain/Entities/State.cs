using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class State : BaseEntity<int>
{
    public string Name { get; private set; }
    public List<City> Cities{ get; private set; }
    public Country Country { get; private set; }

    public State(string name, Country country)
    {
        Name = name;
        Country = country;
        Cities = [];
    }

    private State() { }
}
