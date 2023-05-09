namespace Blog.Service.Application.Bloggers.Commands;

public record CreateCategoryCommand(string name,string description) : Command;