using System.Collections.Generic;
using Volo.Abp.Application.Services;
using Volo.Abp.SettingManagement;
using Volo.Abp.Settings;

namespace Blog.Settings;

public class SettingService : ApplicationService, ISettingService
{
    private readonly ISettingManager _settingManager;

    public SettingService(ISettingManager settingManager)
    {
        _settingManager = settingManager;
    }

    /// <inheritdoc />
    public async Task SetAsync(string name, string value)
    {
        await _settingManager.SetGlobalAsync(name, value);

    }

    /// <inheritdoc />
    public async Task<string> GetAsync(string name)
    {
        return await _settingManager.GetOrNullGlobalAsync(name);
    }

    /// <inheritdoc />
    public async Task<List<SettingValue>> AllAsync()
    {
        return await _settingManager.GetAllGlobalAsync();
    }
}