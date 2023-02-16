using System.Collections.Generic;

namespace Blog;
public class PagedResultDto<T>
{

    public IReadOnlyList<T> Items
    {
        get { return _items ??= new List<T>(); }
        set { _items = value; }
    }
    private IReadOnlyList<T> _items;

    /// <inheritdoc />
    public long TotalCount { get; set; }


    public PagedResultDto()
    {

    }

    public PagedResultDto(long totalCount, IReadOnlyList<T> items)
    {
        TotalCount = totalCount;
    }
}