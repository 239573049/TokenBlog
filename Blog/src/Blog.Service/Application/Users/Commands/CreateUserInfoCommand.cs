using Blog.Contracts.Users;

namespace Blog.Service.Application.Users.Commands;

public record CreateUserInfoCommand(CreateUserInfoDto dto):Command;