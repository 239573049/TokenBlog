using Blog.Component.Pages.Module;
using Blog.Users;

namespace Blog;

public partial class ChatGPT
{
    private List<ChatGptDto> chatDtos = new();

    public UserInfoDto UserInfoDto { get; set; }

    private string Message = string.Empty;

    private string Id;

    private void GetBack()
    {
        NavigationManager.NavigateTo("/");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Id = Guid.NewGuid().ToString();
            UserInfoDto = await UserInfoService.GetProfileAsync();
            await GetListAsync();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task GetListAsync()
    {
        chatDtos = await ChatGPTService.GetListAsync();
        StateHasChanged();
        await HelperJsInterop.ScrollHeight(Id);
    }

    private async Task SendMessage()
    {
        chatDtos.Add(new ChatGptDto()
        {
            ChatGPT = false,
            Content = Message,
            CreatedTime = DateTime.Now.ToString("yyyy-MM-dd")
        });

        await HelperJsInterop.ScrollHeight(Id);
        try
        {
            var message = await ChatGPTService.PostResponse(new PostResponseInput()
            {
                Message = Message
            });

            Message = string.Empty;

            chatDtos.Add(new ChatGptDto()
            {
                ChatGPT = true,
                Content = message,
                CreatedTime = DateTime.Now.ToString("yyyy-MM-dd")
            });
            await HelperJsInterop.ScrollHeight(Id);
        }
        catch (Exception e)
        {
            await PopupService.ToastErrorAsync(e.Message);
        }
    }
}