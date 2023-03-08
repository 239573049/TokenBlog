namespace TokenBlog.Service.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    public async Task<List<Order>> GetListAsync()
    {
        var data = Enumerable.Range(1, 5).Select(index =>
                  new Order(index, DateTimeOffset.Now.ToUnixTimeSeconds().ToString())).ToList();
        return await Task.FromResult(data);
    }
}