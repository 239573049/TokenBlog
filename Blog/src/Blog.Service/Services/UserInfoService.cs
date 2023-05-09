using Blog.Contracts.Users;
using Blog.Service.Application.Users.Commands;
using Blog.Service.Application.Users.Querues;
using Microsoft.AspNetCore.Authorization;

namespace Blog.Service.Services;

public class UserInfoService : BaseService<UserInfoService>
{
    [Authorize]
    public async Task CreateAsync(CreateUserInfoDto dto)
    {
        var commonad = new CreateUserInfoCommand(dto);
        await eventBus.PublishAsync(commonad);
    }

    public async Task<string> Login(string account, string password)
    {
        var query = new GetUserInfoQuery(account, password);
        await eventBus.PublishAsync(query);
        return query.Result;
    }
}
