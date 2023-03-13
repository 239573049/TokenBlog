using TokenBlog.Service.Infrastructure.Entities;

namespace TokenBlog.Service.Infrastructure.Repositories;

public class TabRepository : ITabRepository
{
    public async Task<List<Tab>> GetListAsync()
    {
        return await Task.FromResult(new List<Tab>());
    }
}