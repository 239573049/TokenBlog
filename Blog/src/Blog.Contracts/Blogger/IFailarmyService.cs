using Masa.Utils.Models;

namespace Blog.Contracts.Blogger;

public interface IFailarmyService
{
    Task CreateAsync(CreateFailarmyDto dto);

    Task DeleteAsync(Guid id);

    Task UpdateAsync(UpdateFailarmyDto dto);

    Task<PaginatedListBase<FailarmyDto>> GetListAsync(string? keyword, int page = 1,
        int pageSize = 20);
}