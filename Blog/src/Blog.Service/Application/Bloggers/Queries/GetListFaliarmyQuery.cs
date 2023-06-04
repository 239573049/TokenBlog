namespace Blog.Service.Application.Bloggers.Queries
{
    public record GetListFaliarmyQuery(string? keyword, int page = 1, int pageSize = 20) : Query<PaginatedListBase<FaliarmyDto>>
    {
        public override PaginatedListBase<FaliarmyDto> Result { get; set; }
    }
}
