using CorteCerto.Application.Common;

namespace CorteCerto.Application.Extentions;

public static class PagedResultExtention
{
    public static PagedResult<T> ToPagedResult<T>(this IEnumerable<T> items, int count, int pageSize = 50, int pageNumber = 1)
    {
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);
        var pagedList = new PagedResult<T>(pageSize, pageNumber)
        {
            TotalCount = count,
            TotalPages = totalPages
        };

        pagedList.Results = items;

        return pagedList;
    }
}
