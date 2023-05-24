namespace Blog.Service.Application.Bloggers.Commands;

public record LikeCommand(Guid id) : Command;
