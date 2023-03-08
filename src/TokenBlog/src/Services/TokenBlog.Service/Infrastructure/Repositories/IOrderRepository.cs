namespace TokenBlog.Service.Infrastructure.Repositories;

public interface IOrderRepository : IScopedDependency
{
    Task<List<Order>> GetListAsync();
}