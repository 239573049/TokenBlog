namespace Blog.Service.Application.Bloggers.Queries;

public record GetRankingQuery() : Query<List<GetArticleListDto>>
{
    public override List<GetArticleListDto> Result { get; set; }
}
