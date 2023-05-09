using Blog.Service.Application.Bloggers.Commands;
using Blog.Service.Domain.Bloggers.Repositories;
using Masa.BuildingBlocks.Data.UoW;

namespace Blog.Service.Application.Bloggers;

public class CategoryCommandHandler
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }

    [EventHandler]
    public async Task CreateCategoryAsync(CreateCategoryCommand command)
    {
        if(await _categoryRepository.FindAsync(x=>x.Name == command.name) != null)
        {
            throw new UserFriendlyException("已经存在相同名称");
        }

        await _categoryRepository.AddAsync(new Category(command.name,command.description));
        await _unitOfWork.SaveChangesAsync();
    }
}
