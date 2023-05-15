using Blog.Service.Domain.Resources.Aggregates;

namespace Blog.Service.Domain.Resources.Repositories;

public interface IResourceRepository : IRepository<Resource,Guid>
{
    /// <summary>
    /// 点赞
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task PraiseAsync(Guid id);

    /// <summary>
    /// 获取资源
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<string> DownloadAsync(Guid id);
}
