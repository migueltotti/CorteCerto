using CorteCerto.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Application.Extentions;

public static class PagedListExtention
{
    public static PagedList<T> ToPagedList<T>(this IEnumerable<T> source, int pageNumber = 50, int pageSize = 1)
    {
        var count = source.Count();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);
        var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        var pagedList = new PagedList<T>(pageSize, pageNumber)
        {
            TotalCount = count,
            TotalPages = totalPages
        };

        pagedList.AddRange(items);

        return pagedList;
    }
}
