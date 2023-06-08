using Blog.Contracts.Resources;
using Masa.Utils.Models;

namespace Blog.Contracts.Blogger;

public interface IResourceService
{
    Task<PaginatedListBase<ResourceDto>> GetListAsync(string? keywords, int page, int pageSize);

    Task CreateAsync(CreateResourceDto dto);

    Task PraiseAsync(Guid id);

    Task<string> DownloadAsync(Guid id);

    Task DeleteAsync(Guid id);

    Task UpdateAsync(UpdateResourceDto dto);
}