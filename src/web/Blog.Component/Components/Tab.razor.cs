using Blog.Blog.Dto;
using Blog.Dto;

namespace Blog.Component;

public partial class Tab
{
    private List<TagDto>? _tagDtos;

    public Guid? TagId { get; set; }

    private void SwitchTag(Guid? tagId)
    {
        if (tagId == Guid.Empty)
        {
            TagId = null;
        }
        else
        {
            TagId = tagId;
        }
    }

    private async Task LoadTag()
    {
        _tagDtos = new List<TagDto>()
        {
            new()
            {
                Rank = 0,
                Title = "推荐"
            }
        };
        _tagDtos.AddRange(await TagService.GetListAsync());
    }

    protected override async Task OnInitializedAsync()
    {
        await LoadTag();
        await base.OnInitializedAsync();
    }
}