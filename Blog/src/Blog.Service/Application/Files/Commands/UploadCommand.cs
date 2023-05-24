namespace Blog.Service.Application.Files.Commands;

public record UploadCommand(Stream stream,string name,string type) : Command
{
    public string Result { get; set; }
}