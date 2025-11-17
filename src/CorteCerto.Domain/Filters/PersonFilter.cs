using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Filters;

public class PersonFilter
{
    public Guid? Id { get; private set; } = null;
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

        public Builder WithPagination(int PageSize, int PageNumber)
        {
            _filter.PageSize = PageSize;
            _filter.PageNumber = PageNumber;
            return this;
        } 

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

        public PersonFilter Build()
        {
            return _filter;
        }
    }
}
