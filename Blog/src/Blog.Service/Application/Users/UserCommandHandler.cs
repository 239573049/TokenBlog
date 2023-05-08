using Blog.Contracts.Shared;
using Blog.Service.Application.Users.Commands;
using Blog.Service.Domain.Users.Aggregates;
using Blog.Service.Domain.Users.Repositories;
using Masa.BuildingBlocks.Data.UoW;

namespace Blog.Service.Application.Users;

public class UserCommandHandler
{
    private readonly IUserInfoRepository _userInfoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UserCommandHandler(IUserInfoRepository userInfoRepository, IUnitOfWork unitOfWork)
    {
        _userInfoRepository = userInfoRepository;
        _unitOfWork = unitOfWork;
    }

    [EventHandler(1)]
    public async Task VerifyUser(CreateUserInfoCommand command)
    {
        if (await _userInfoRepository.AnyAsync(command.dto.Account, command.dto.Email))
        {
            throw new UserFriendlyException("账号或邮箱已存在");
        }
    }

    [EventHandler(2)]
    public async Task CreateUserInfo(CreateUserInfoCommand command)
    {
        var user = new UserInfo(Guid.NewGuid(), command.dto.Account, command.dto.Password, command.dto.Email, command.dto.Account, Constant.Role.User);

        await _userInfoRepository.AddAsync(user);
        await _unitOfWork.SaveChangesAsync();
    }
}
