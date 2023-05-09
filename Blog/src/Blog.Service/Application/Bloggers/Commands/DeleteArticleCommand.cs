namespace Blog.Service.Application.Bloggers.Commands;

public record DeleteArticleCommand(Guid id) : Command;
