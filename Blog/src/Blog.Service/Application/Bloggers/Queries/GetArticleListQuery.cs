
namespace Blog.Service.Application.Bloggers.Queries;

public record GetArticleListQuery(string? keyword,Guid? categoryId,string? tabIds,int page = 1,int pageSize = 20) : Query<PaginatedListBase<GetArticleListDto>>
{
    public override PaginatedListBase<GetArticleListDto> Result { get; set; }
}