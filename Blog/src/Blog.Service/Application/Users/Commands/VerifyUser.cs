using Blog.Contracts.Users;

namespace Blog.Service.Application.Users.Commands;

public record VerifyUser(CreateUserInfoDto dto) : Command;
