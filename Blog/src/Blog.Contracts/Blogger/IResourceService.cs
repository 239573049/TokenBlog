using Blog.Contracts.Resources;
using Masa.Utils.Models;
using WebApiClientCore.Attributes;

namespace Blog.Contracts.Blogger;

public interface IResourceService
{
    [HttpGet("Resources/List")]
    Task<PaginatedListBase<ResourceDto>> GetListAsync(string? keywords, int page, int pageSize);

    [HttpPost("Resources")]
    Task CreateAsync(CreateResourceDto dto);

    [HttpPost("Resources/Praise/{id}")]
    Task PraiseAsync(Guid id);

    [HttpPost("Resources/Download/{id}")]
    Task<string> DownloadAsync(Guid id);

    [HttpDelete("Resources/{id}")]
    Task DeleteAsync(Guid id);

    [HttpPut("Resources")]
    Task UpdateAsync(UpdateResourceDto dto);
}