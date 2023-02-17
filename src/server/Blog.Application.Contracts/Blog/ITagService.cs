using Blog.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog;

public interface ITagService
{
    Task<List<TagDto>> GetListAsync();

    /// <summary>
    /// 创建Tag
    /// </summary>
    /// <returns></returns>
    Task CreateAsync(TagDto input);
}