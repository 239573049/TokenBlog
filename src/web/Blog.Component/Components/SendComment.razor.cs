using BlazorComponent;
using Microsoft.AspNetCore.Components;

namespace Blog.Component;

public partial class SendComment
{
    [Parameter]
    public string Comment { get; set; }
    
    [Parameter]
    public EventCallback<string> CommentChanged { get; set; }
    
    private StringNumber tab;
}