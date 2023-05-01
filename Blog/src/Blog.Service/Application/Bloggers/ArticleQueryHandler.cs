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
            .Select(x => new GetArticleListDto()
            {
                Id = x.Id,
                Title = x.Title,
                CategoryId = x.CategoryId,
                ReadCount = x.ReadCount,
                UserId = x.UserId,
                PublishTime = x.PublishTime,
                Like = x.Like,
                CreationTime = x.CreationTime,
                CategoryName = x.Category?.Name
                // UserName = x.UserName,
            }).ToList();

        var count = await _articleRepository.GetCountAsync(query.keyword, query.categoryId);


        query.Result = new PaginatedListBase<GetArticleListDto>()
        {
            Result = result,
            Total = count
        };
    }

    [EventHandler]
    public async Task GetArticleAsync(GetArticleQuery query)
    {
        var result = await _articleRepository.GetAsync(query.id);

        if (result == null)
        {
            throw new UserFriendlyException("不存在博客");
        }

        query.Result = new ArticleDto()
        {
            CategoryId = result.CategoryId,
            Title = result.Title,
            Content = result.Content,
            CreationTime = result.CreationTime,
            Id = result.Id,
            Like = result.Like,
            UserId = result.UserId,
            PublishTime = result.PublishTime,
            Tabs = result.Tabs,
            CategoryName = result.Category?.Name ?? string.Empty,
            ReadCount = result.ReadCount,
        };
    }

    [EventHandler]
    public async Task GetRankingAsync(GetRankingQuery query)
    {
        query.Result = (await _articleRepository.GetRankingAsync()).Select(x => new GetArticleListDto()
        {
            Id = x.Id,
            Title = x.Title,
            CategoryId = x.CategoryId,
            ReadCount = x.ReadCount,
            UserId = x.UserId,
            PublishTime = x.PublishTime,
            Like = x.Like,
            CreationTime = x.CreationTime,
            CategoryName = x.Category?.Name
            // UserName = x.UserName,
        }).ToList();

    }
}