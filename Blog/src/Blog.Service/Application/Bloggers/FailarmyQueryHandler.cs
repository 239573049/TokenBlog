namespace Blog.Service.Application.Bloggers
{
    public class FailarmyQueryHandler
    {
        private readonly IFailarmyRepository _failarmyRepository;

        public FailarmyQueryHandler(IFailarmyRepository failarmyRepository)
        {
            _failarmyRepository = failarmyRepository;
        }

        [EventHandler]
        public async Task GetListAsync(GetListFaliarmyQuery query)
        {
            var list = await _failarmyRepository.GetListAsync(query.keyword, query.page, query.pageSize);

            var count = await _failarmyRepository.GetCountAsync(query.keyword);

            query.Result = new PaginatedListBase<FaliarmyDto> { Total = count, Result = list };
        }
    }
}
