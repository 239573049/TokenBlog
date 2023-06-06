namespace Blog.Service.Application.Bloggers.Queries;

public record GetArticleQuery(int id) : Query<ArticleDto>()
{
    public override ArticleDto Result { get; set; }
}
