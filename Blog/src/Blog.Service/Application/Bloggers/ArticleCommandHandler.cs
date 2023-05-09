using Blog.Service.Application.Bloggers.Commands;
using Masa.BuildingBlocks.Authentication.Identity;
using Masa.BuildingBlocks.Data.UoW;

namespace Blog.Service.Application.Bloggers;

public class ArticleCommandHandler
{
    private readonly IArticleRepository _articleRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;

    public ArticleCommandHandler(IArticleRepository articleRepository, IUserContext userContext, IUnitOfWork unitOfWork)
    {
        _articleRepository = articleRepository;
        _userContext = userContext;
        _unitOfWork = unitOfWork;
    }

    [EventHandler(1)]
    public async Task CreateArticle(CreateArticleCommand command)
    {
        var data = command.Dto;

        await _articleRepository.AddAsync(new Article(Guid.NewGuid(),
            data.Title,
            data.Content,
            DateTime.UtcNow,
            Guid.Parse(_userContext.UserId),
            0,
            0,
            data.CategoryId,
            data.Tabs));

        await _unitOfWork.SaveChangesAsync();
    }

    [EventHandler]
    public async Task DeleteArticleAsync(DeleteArticleCommand command)
    {
        var data = await _articleRepository.FindAsync(x => x.Id == command.id);
        await _articleRepository.RemoveAsync(data);
        await _unitOfWork.SaveChangesAsync();
    }
}
