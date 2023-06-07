using Blog.Contracts.Blogger;

namespace Blog.Service.Domain.Bloggers.Repositories
{
    public interface IFailarmyRepository : IRepository<Failarmy>
    {
        Task<List<FailarmyDto>> GetListAsync(string? keyword, int page = 1, int pageSize = 20);

        Task<int> GetCountAsync(string? keyword);
    }
}
