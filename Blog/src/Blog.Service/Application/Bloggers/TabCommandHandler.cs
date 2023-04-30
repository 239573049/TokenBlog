using Blog.Service.Application.Bloggers.Commands;
using Masa.BuildingBlocks.Data.UoW;

namespace Blog.Service.Application.Bloggers;

public class TabCommandHandler
{
    private readonly ITabRepository _tabRepository;
    private readonly IUnitOfWork _unitOfWork;

    public TabCommandHandler(ITabRepository tabRepository, IUnitOfWork unitOfWork)
    {
        _tabRepository = tabRepository;
        _unitOfWork = unitOfWork;
    }

    [EventHandler]
    public async Task CreateTab(CreateTabCommand command)
    {
        if(await _tabRepository.FindAsync(x => x.Name == command.name) != null)
        {
            throw new UserFriendlyException("存在相同标签");
        }

        await _tabRepository.AddAsync(new Tab()
        {
            Name = command.name,
        });
        
        await _unitOfWork.SaveChangesAsync();
    }
}
