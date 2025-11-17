namespace CorteCerto.Application.Common;

public class PagedResult<T>
{
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages { get; set; }
    public IEnumerable<T> Results { get; set; } = [];

    public PagedResult(int pageSize, int pageNumber)
    {
        PageSize = pageSize;
        PageNumber = pageNumber;
    }
}
