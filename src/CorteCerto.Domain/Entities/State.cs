using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Entities;

public class State : BaseEntity<int>
{
    public string Acronym { get; private set; }
    public string Name { get; private set; }
    public List<City>? Cities { get; private set; }
    public int CountryId { get; private set; }
    public Country? Country { get; private set; }

    public State(string name, string acronym, int countryId)
    {
        Name = name;
        CountryId = countryId;
        Cities = [];
        Acronym = acronym;
    }

    private State() { }
}
