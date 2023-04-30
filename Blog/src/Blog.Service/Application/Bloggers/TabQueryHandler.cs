namespace Blog.Service.Application.Bloggers;

public class TabQueryHandler
{
    private readonly ITabRepository _tabRepository;

    public TabQueryHandler(ITabRepository tabRepository)
    {
        _tabRepository = tabRepository;
    }

    [EventHandler]
    public async Task GetListAsync(GetTabListQuery query)
    {
        query.Result = (await _tabRepository.GetListAsync()).Select(x => new TabDto()
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }
}
