using Blog.Blog.Dto;
using System.Threading.Tasks;

namespace Blog.Blog;

public interface IBlogInfoService
{
    /// <summary>
    /// 获取博客基本信息
    /// </summary>
    /// <returns></returns>
    Task<BlogInfoDto> GetBlogInfoAsync();
}