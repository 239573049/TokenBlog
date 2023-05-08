using Blog.Service.Domain.Users.Aggregates;
using Blog.Service.Domain.Users.Repositories;
using Masa.BuildingBlocks.Data.UoW;
using Masa.Contrib.Ddd.Domain.Repository.EFCore;

namespace Blog.Service.Infrastructure.Repositories;

public class UserInfoRepository : Repository<BlogDbContext, UserInfo, Guid>, IUserInfoRepository
{
    public UserInfoRepository(BlogDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public Task<bool> AnyAsync(string account, string email)
    {
        return Context.UserInfos.AnyAsync(x => x.Account == account || x.Email == email);
    }
}
