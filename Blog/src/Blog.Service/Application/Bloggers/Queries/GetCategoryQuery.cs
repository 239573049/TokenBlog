namespace Blog.Service.Application.Bloggers.Queries;

public record GetCategoryQuery() : Query<List<CategoryDto>>
{
    public override List<CategoryDto> Result { get; set; }
}
