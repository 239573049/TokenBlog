using Blog.Service.Domain.Users.Aggregates;

namespace Blog.Service.Domain.Users.Repositories;

public interface IUserInfoRepository : IRepository<UserInfo>
{
    Task<bool> AnyAsync(string account,string email);
}
