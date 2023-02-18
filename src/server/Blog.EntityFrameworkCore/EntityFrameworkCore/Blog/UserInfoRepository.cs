using Blog.Blog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Blog;

public class UserInfoRepository : EfCoreRepository<BlogDbContext, UserInfo, Guid>, IUserInfoRepository
{
    public UserInfoRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task UpdateChatGptNumberAsync(Guid id)
    {
        var dbContext = await GetDbContextAsync();

        await dbContext.Database.ExecuteSqlRawAsync($"UPDATE UserInfos SET ChatGptNumber=ChatGptNumber-1 WHERE Id = '{id}'");
    }
}
