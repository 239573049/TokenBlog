namespace Blog.Service.Application.Bloggers.Queries;

public record GetTabListQuery() : Query<List<TabDto>>
{
    public override List<TabDto> Result { get; set; }
}
