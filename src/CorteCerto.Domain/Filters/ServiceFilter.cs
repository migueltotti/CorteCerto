namespace CorteCerto.Domain.Filters;

public class ServiceFilter
{
    public IEnumerable<int>? Ids { get; set; } = null!;
    public string? Name { get; private set; } = null!;
    public decimal? Price { get; private set; } = null!;
    public PriceOperator PriceOperator { get; private set; } = default;
    public TimeSpan? Duration { get; private set; } = null!;
    public DurationOperator DurationOperator { get; private set; } = default;
    public int PageSize { get; set; } = 50;
    public int PageNumber { get; set; } = 1;

    public ServiceFilter()
    {
    }

    public class Builder
    {
        private readonly ServiceFilter _serviceFilter = new();

        public Builder WithPagination(int PageSize, int PageNumber)
        {
            _serviceFilter.PageSize = PageSize;
            _serviceFilter.PageNumber = PageNumber;
            return this;
        }
        
        public Builder WithIds(IEnumerable<int>? ids)
        {
            _serviceFilter.Ids = ids;
            return this;
        }
        
        public Builder WithName(string? name)
        {
            _serviceFilter.Name = name;
            return this;
        }

        public Builder WithPrice(decimal? price, PriceOperator @operator)
        {
            _serviceFilter.Price = price;
            _serviceFilter.PriceOperator = @operator;
            return this;
        }

        public Builder WithDuration(TimeSpan? duration, DurationOperator @operator)
        {
            _serviceFilter.Duration = duration;
            _serviceFilter.DurationOperator = @operator;
            return this;
        }

        public ServiceFilter Build()
        {
            return _serviceFilter;
        }
    }
}
