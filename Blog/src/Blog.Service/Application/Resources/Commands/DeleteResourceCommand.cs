namespace Blog.Service.Application.Resources.Commands
{
    public record DeleteResourceCommand(Guid id) : Command;
}
