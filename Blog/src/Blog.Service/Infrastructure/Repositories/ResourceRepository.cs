using Blog.Service.Domain.Resources.Aggregates;
using Blog.Service.Domain.Resources.Repositories;
using Masa.BuildingBlocks.Data.UoW;
using Masa.Contrib.Ddd.Domain.Repository.EFCore;

namespace Blog.Service.Infrastructure.Repositories;

public class ResourceRepository : Repository<BlogDbContext, Resource, Guid>, IResourceRepository
{
    public ResourceRepository(BlogDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public async Task<string> DownloadAsync(Guid id)
    {
        var value = await Context.Resources.FirstOrDefaultAsync(x => x.Id == id);

        if (value == null)
        {
            return string.Empty;
        }

        await Context.Database.ExecuteSqlRawAsync(
            $"update \"Resources\" set \"DownloadCount\" = \"DownloadCount\"+1 where \"Id\" = '{id}'");

        return value.Url;
    }

    public async Task PraiseAsync(Guid id)
    {
        await Context.Database.ExecuteSqlRawAsync(
            $"update \"Resources\" set \"Referee\" = \"Referee\"+1 where \"Id\" = '{id}'");
    }
}
