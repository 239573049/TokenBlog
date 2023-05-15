using Blog.Contracts.Resources;

namespace Blog.Service.Application.Resources.Commands;

public record CreateResourceCommand(CreateResourceDto dto) : Command;