using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Blog.Dto;

namespace Blog.Blog;

public interface ITagService
{
    Task<List<TagDto>> GetListAsync();

    /// <summary>
    /// 创建Tag
    /// </summary>
    /// <returns></returns>
    Task CreateAsync(TagDto input);
}