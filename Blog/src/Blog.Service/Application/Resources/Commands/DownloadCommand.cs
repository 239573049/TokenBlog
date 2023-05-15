namespace Blog.Service.Application.Resources.Commands;

public record DownloadCommand(Guid id) : Command
{
    public string Url { get; set; }
}