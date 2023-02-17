using Blog.Blog.Dto;
using Volo.Abp.Application.Services;

namespace Blog.Blog;

public class BlogInfoService : ApplicationService, IBlogInfoService
{
    public Task<BlogInfoDto> GetBlogInfoAsync()
    {
        throw new NotImplementedException();
    }
}