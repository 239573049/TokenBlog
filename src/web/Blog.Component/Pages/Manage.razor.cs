using BlazorComponent;
using Blog.Blog.Dto;
using Volo.Abp.Application.Dtos;

namespace Blog.Component;

public partial class Manage
{
    private StringNumber Tab;

    private bool _dialogDelete;

    private ArticleUserInfoDto? DeleteArticleUserInfoDto;

    private GetArticleUserInfoInput _infoInput = new();

    /// <summary>
    /// 加载动画
    /// </summary>
    private bool _loading;

    private DataOptions _options = new();

    private PagedResultDto<ArticleUserInfoDto> _pagedResult;

    private List<DataTableHeader<ArticleUserInfoDto>> _headers = new()
    {
        new() { Text = "标题", Value = nameof(ArticleUserInfoDto.Title) },
        new() { Text = "发布时间", Value = nameof(ArticleUserInfoDto.CreationTime) },
        new() { Text = "浏览量", Value = nameof(ArticleUserInfoDto.Flow) },
        new() { Text = "点赞", Value = nameof(ArticleUserInfoDto.Praise) },
        new() { Text = "操作", Value = "actions", Sortable = false }
    };

    private void Back()
    {
        NavigationManager.NavigateTo("/");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await GetListAsync();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    public async Task HandleOnOptionsUpdate(DataOptions options)
    {
        _options = options;
        await GetListAsync();
    }

    private async Task GetListAsync()
    {
        _loading = true;
        var page = _options.Page;
        var itemsPerPage = _options.ItemsPerPage;
        _infoInput.Page = page;
        _infoInput.PageSize = itemsPerPage;
        _pagedResult = await ArticleService.GetArticleUserInfoAsync(_infoInput);
        _loading = false;
    }

    private async Task Delete()
    {
        if (DeleteArticleUserInfoDto == null)
        {
            return;
        }

        await ArticleService.DeleteUserInfoAsync(DeleteArticleUserInfoDto!.Id);
        _dialogDelete = false;
        await PopupService.ToastSuccessAsync("删除成功");
        await GetListAsync();
    }

    private void CloseDelete()
    {
        DeleteArticleUserInfoDto = null;
        _dialogDelete = false;
    }

    private void DeleteItem(ArticleUserInfoDto item)
    {
        DeleteArticleUserInfoDto = item;
        _dialogDelete = true;
    }
}