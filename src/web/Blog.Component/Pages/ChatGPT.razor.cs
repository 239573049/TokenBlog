using Blog.Component.Pages.Module;
using Blog.Users;
using Microsoft.AspNetCore.Components.Web;

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

    private async Task OnKey(KeyboardEventArgs args)
    {
        if (args.Key == "Enter")
        {
            await SendMessage();
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var token = await HelperJsInterop.GetTokenAsync();

            if (HttpClient.DefaultRequestHeaders.Any(x => x.Key == "Authorization"))
            {
                HttpClient.DefaultRequestHeaders.Remove("Authorization");
            }

            HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            Id = Guid.NewGuid().ToString();
            try
            {
                UserInfoDto = await UserInfoService.GetProfileAsync();
            }
            catch (UnauthorizedAccessException e)
            {
                await PopupService.ToastErrorAsync("请先登录");
                await Task.Delay(2000);
                NavigationManager.NavigateTo("/");
            }
            await GetListAsync();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task GetListAsync()
    {
        chatDtos = await ChatGPTService.GetListAsync();
        StateHasChanged();
        await HelperJsInterop.ScrollHeight(Id, 200);
        await HelperJsInterop.ScrollHeight(Id, 50);
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
            Message = string.Empty;

            var message = await ChatGPTService.PostResponse(new PostResponseInput()
            {
                Message = Message
            });

            chatDtos.Add(new ChatGptDto()
            {
                ChatGPT = true,
                Content = message,
                CreatedTime = DateTime.Now.ToString("yyyy-MM-dd")
            });
            await HelperJsInterop.ScrollHeight(Id);
        }
        catch (UnauthorizedAccessException e)
        {
            await PopupService.ToastErrorAsync("请先登录");
            await Task.Delay(2000);
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            await PopupService.ToastErrorAsync(e.Message);
        }
    }
}