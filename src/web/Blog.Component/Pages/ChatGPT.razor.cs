using Blog.Component.Pages.Module;
using Blog.Users;
using Microsoft.AspNetCore.Components.Web;

namespace Blog;

public partial class ChatGPT
{
    private List<ChatGptDto> chatDtos = new();

    public UserInfoDto UserInfoDto { get; set; }

    private string Message = string.Empty;
    
    private object Options;

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

    protected override void OnInitialized()
    {
        
        Options = new
        {
            value = "", // 初始代码
            language = "markdown", // 语法支持语言
            automaticLayout = true, //自动适应父容器大小
            theme = "vs-dark" // monaco主题 
        };
        
        base.OnInitialized();
    }

    private async Task GetListAsync()
    {
        chatDtos = await ChatGPTService.GetListAsync();
        StateHasChanged();
        await HelperJsInterop.ScrollHeight(Id, 200);
        await HelperJsInterop.ScrollHeight(Id, 100);
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
            string? v = Message;
            
            Message = string.Empty;
            await Task.Delay(20);
            
            StateHasChanged();

            var message = await ChatGPTService.PostResponse(new PostResponseInput()
            {
                Message = v
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