namespace Blog;

public class BusinessErrorDto
{
    public Error error { get; set; }
}

public class Error
{
    public string code { get; set; }
    public string message { get; set; }
    public object details { get; set; }
}
