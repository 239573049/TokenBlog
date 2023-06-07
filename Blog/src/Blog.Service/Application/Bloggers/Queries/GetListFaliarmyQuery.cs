namespace Blog.Service.Application.Bloggers.Queries
{
    public record GetListFaliarmyQuery(string? keyword, int page = 1, int pageSize = 20) : Query<PaginatedListBase<FailarmyDto>>
    {
        public override PaginatedListBase<FailarmyDto> Result { get; set; }
    }
}
