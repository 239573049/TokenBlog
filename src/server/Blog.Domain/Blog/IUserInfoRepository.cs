using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Blog.Blog;

public interface IUserInfoRepository : IRepository<UserInfo,Guid>
{
    /// <summary>
    /// 更新ChatGpt访问余额
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task UpdateChatGptNumberAsync(Guid id);
}
