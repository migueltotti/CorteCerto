using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Filters;

public class PersonFilter
{
    public IEnumerable<Guid>? Ids { get; private set; } = null;
    public string? Name { get; private set; } = null;
    public string? Email { get; private set; } = null;
    public int PageSize { get; set; } = 50;
    public int PageNumber { get; set; } = 1;

    private PersonFilter()
    {
    }

    public class Builder
    {
        private readonly PersonFilter _filter = new();

        public Builder WithPagination(int pageSize, int pageNumber)
        {
            _filter.PageSize = pageSize;
            _filter.PageNumber = pageNumber;
            return this;
        } 

        public Builder WithIds(IEnumerable<Guid>? id)
        {
            _filter.Ids = id;
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

        public PersonFilter Build()
        {
            return _filter;
        }
    }
}
