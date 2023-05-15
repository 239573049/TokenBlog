using Blog.Contracts.Resources;

namespace Blog.Service.Application.Resources.Queries;

public record GetResourceListQuery(string? keywords, int page, int pageSize) : Query<PaginatedListBase<ResourceDto>>
{
    public override PaginatedListBase<ResourceDto> Result { get; set; }
}