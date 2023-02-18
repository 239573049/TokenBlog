using Blog.Component.Pages.Module;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog;

public interface IChatGptService
{
    /// <summary>
    /// 获取回复
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    Task<string> PostResponse(PostResponseInput input);

    /// <summary>
    /// 获取记录
    /// </summary>
    /// <returns></returns>
    Task<List<ChatGptDto>> GetListAsync();
}