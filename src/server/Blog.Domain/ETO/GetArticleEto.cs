namespace Blog.ETO;

public class GetArticleEto
{
    public Guid Id { get; set; }

    public GetArticleEto(Guid id)
    {
        Id = id;
    }
}