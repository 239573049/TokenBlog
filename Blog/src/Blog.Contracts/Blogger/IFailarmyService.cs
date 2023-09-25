using Masa.Utils.Models;
using WebApiClientCore.Attributes;

namespace Blog.Contracts.Blogger;

public interface IFailarmyService
{
    [HttpPost("Failarmies")]
    Task CreateAsync(CreateFailarmyDto dto);

    [HttpDelete("Failarmies/{id}")]
    Task DeleteAsync(Guid id);

    [HttpPut("Failarmies")]
    Task UpdateAsync(UpdateFailarmyDto dto);

    [HttpGet("Failarmies/List")]
    Task<PaginatedListBase<FailarmyDto>> GetListAsync(string? keyword, int page = 1,
        int pageSize = 20);
}