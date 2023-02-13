using Volo.Abp.Application.Dtos;

namespace Blog;

public class PagedRequestInput : PagedResultRequestDto
{
    private int? _page = 1;
    private int? _pageSize = 20;

    /// <summary>
    /// 页码, 默认1
    /// </summary>
    public int? Page
    {
        get => _page;
        set => _page = value is null or <= 0 ? 1 : value;
    }

    /// <summary>
    /// 页大小, 默认20
    /// </summary>
    public int? PageSize
    {
        get => _pageSize;
        set => _pageSize = value is null or <= 0 ? 20 : value;
    }

    /// <summary>
    /// 忽略. 只传 Page 和 PageSize
    /// </summary>
    public new int SkipCount => (Page!.Value - 1) * MaxResultCount;

    /// <summary>
    /// 忽略. 只传 Page 和 PageSize
    /// </summary
    public new int MaxResultCount =>
        PageSize!.Value > MaxMaxResultCount
            ? MaxMaxResultCount
            : PageSize!.Value;
}