using BlazorComponent;
using Blog.Blog.Dto;
using Microsoft.AspNetCore.Components;

namespace Blog.Component;

public partial class SendComment
{
    [Parameter]
    [CascadingParameter(Name = nameof(ArticleId))]
    public Guid ArticleId { get; set; }
    
    [Parameter]
    public string Comment { get; set; }
    
    [Parameter]
    public EventCallback<string> CommentChanged { get; set; }
    
    private StringNumber tab;

    private async Task Send()
    {
        try
        {
            await ArticleCommentService.CreateAsync(new CreateArticleCommentInput
            {
                ArticleId = ArticleId,
                Content = Comment
            });
            Comment = string.Empty;
            await KeyLoadEventBus.PushAsync(EventBusConstant.GetComment, string.Empty);
            await PopupService.ToastSuccessAsync("评论成功");
        }
        catch
        {
            await PopupService.ToastErrorAsync("评论失败");
        }
    }
}