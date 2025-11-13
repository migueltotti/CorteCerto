namespace CorteCerto.Domain.Filters;

public class BarbersFilter
{
    public Guid? Id { get; private set; } = null;
    public string? Name { get; private set; } = null;
    public string? Email { get; private set; } = null;

    private BarbersFilter()
    {
    }

    public class Builder
    {
        private BarbersFilter _filter = new();

        public Builder WithId(Guid? id)
        {
            _filter.Id = id;
            return this;
        }

        public Builder WithName(string? name)
        {
            _filter.Name = name;
            return this;
        }

        public Builder WithEmail(string? email)
        {
            _filter.Email = email;
            return this;
        }

        public BarbersFilter Build()
        {
            return _filter;
        }
    }
}
