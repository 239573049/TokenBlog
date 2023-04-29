using Blog.Service.Domain.Bloggers.Repositories;

namespace Blog.Service.Application.Bloggers;

public class ArticleQueryHandler
{
    private readonly IArticleRepository _articleRepository;

    public ArticleQueryHandler(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    [EventHandler]
    public async Task GetList(GetArticleListQuery query)
    {
        var result =
            (await _articleRepository.GetListAsync(query.keyword, query.categoryId, query.page, query.pageSize))
            .Select(x => new GetArticleListDto()).ToList();

        var count = await _articleRepository.GetCountAsync(query.keyword, query.categoryId);


        query.Result = new PaginatedListBase<GetArticleListDto>()
        {
            Result = result,
            Total = count
        };
    }
}