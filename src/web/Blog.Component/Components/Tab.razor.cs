using Blog.Blog.Dto;

namespace Blog.Component;

public partial class Tab
{
    private List<TagDto>? _tagDtos;

    public async Task LoadTag()
    {
        _tagDtos = await TagService.GetListAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        await LoadTag();
        await base.OnInitializedAsync();
    }
}