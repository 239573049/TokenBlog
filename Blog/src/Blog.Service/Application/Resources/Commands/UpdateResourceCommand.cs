using Blog.Contracts.Resources;

namespace Blog.Service.Application.Resources.Commands
{
    public record UpdateResourceCommand(UpdateResourceDto Dto) : Command;
}
