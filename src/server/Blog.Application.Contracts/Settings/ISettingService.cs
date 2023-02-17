using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Settings;

namespace Blog.Settings;

public interface ISettingService
{
    /// <summary>
    /// 添加设置
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    Task SetAsync(string name, string value);

    /// <summary>
    /// 获取指定设置
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    Task<string> GetAsync(string name);

    /// <summary>
    /// 获取所有设置
    /// </summary>
    /// <returns></returns>
    Task<List<SettingValue>> AllAsync();
}