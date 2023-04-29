using Blog.Service.Domain.Bloggers.Repositories;
using Masa.BuildingBlocks.Data.UoW;
using Masa.Contrib.Ddd.Domain.Repository.EFCore;

namespace Blog.Service.Infrastructure.Repositories;

public class TabRepository : Repository<BlogDbContext, Tab>, ITabRepository
{
    public TabRepository(BlogDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }
}