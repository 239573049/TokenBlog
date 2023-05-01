namespace Blog.Service.Application.Bloggers.Queries;

public record GetArticleQuery(Guid id) : Query<ArticleDto>()
{
    public override ArticleDto Result { get; set; }
}
