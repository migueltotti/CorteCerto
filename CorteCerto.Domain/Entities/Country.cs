using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class Country : BaseEntity<int>
{
    public string Name { get; private set; }
    public List<State> States { get; private set; }
        
    public Country(int id, string name) : base(id)
    {
        Name = name;
        States = [];
    }

    private Country() { }
}
