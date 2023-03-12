using TokenBlog.Service.Order.Infrastructure.Entities;

namespace TokenBlog.Service.Infrastructure.Repositories;

public interface ITabRepository : IScopedDependency
{
    Task<List<Tab>> GetListAsync();
}