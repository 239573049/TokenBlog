using Blog.Service.Application.Resources.Queries;
using Blog.Service.Domain.Resources.Aggregates;
using Blog.Service.Domain.Resources.Repositories;

namespace Blog.Service.Application.Resources;

public class ResourceQueryHandler
{
    private readonly IResourceRepository _resourceRepository;

    public ResourceQueryHandler(IResourceRepository resourceRepository)
    {
        _resourceRepository = resourceRepository;
    }

    [EventHandler]
    public async Task GetListAsync(GetResourceListQuery query)
    {
        var result = await _resourceRepository
            .GetPaginatedListAsync(x => string.IsNullOrEmpty(query.keywords) || x.Title.Contains(query.keywords), new PaginatedOptions()
            {
                Page = query.page,
                PageSize = query.pageSize,
                Sorting = new Dictionary<string, bool>
                {
                    { nameof(Resource.Referee), true }
                }
            });

        query.Result = new PaginatedListBase<Contracts.Resources.ResourceDto>()
        {
            Total = result.Total,
            Result = result.Result.Select(x => new Contracts.Resources.ResourceDto()
            {
                Description = x.Description,
                Id = x.Id,
                DownloadCount = x.DownloadCount,
                Href = x.Href,
                Referee = x.Referee,
                Title = x.Title,
                UserName = x.UserName

            }).ToList()
        };
    }
}
