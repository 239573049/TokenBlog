using Blog.Blog;
using Blog.ETO;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
using Volo.Abp.Uow;

namespace Blog.EntityFrameworkCore;

[UnitOfWork]
public class ArticleEventBusHandle : ILocalEventHandler<GetArticleEto>, ITransientDependency
{
    private readonly IArticlesRepository _articlesRepository;

    public ArticleEventBusHandle(IArticlesRepository articlesRepository)
    {
        _articlesRepository = articlesRepository;
    }

    public async Task HandleEventAsync(GetArticleEto eventData)
    {
        await _articlesRepository.UpdateFlowAsync(eventData.Id);
    }
}