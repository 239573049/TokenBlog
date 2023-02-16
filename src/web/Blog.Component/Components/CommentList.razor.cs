using Blog.Blog.Dto;
using Microsoft.AspNetCore.Components;

namespace Blog.Component;

public partial class CommentList
{
    private List<GetArticleCommentDto> Comments { get; set; } = new();

    [Parameter]
    [CascadingParameter(Name = nameof(ArticleId))]
    public Guid ArticleId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetComment();

        KeyLoadEventBus.Subscription(EventBusConstant.GetComment, async (v) => await GetComment());
        await base.OnInitializedAsync();
    }

    private async Task GetComment()
    {
        Comments = await ArticleCommentService.GetListAsync(new GetArticleCommentInput()
        {
            ArticleId = ArticleId
        });

        _ = InvokeAsync(StateHasChanged);
    }
}