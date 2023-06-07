using Masa.BuildingBlocks.Data.UoW;
using Masa.Contrib.Ddd.Domain.Repository.EFCore;

namespace Blog.Service.Infrastructure.Repositories
{
    public class FailarmyRepository : Repository<BlogDbContext, Failarmy, Guid>, IFailarmyRepository
    {
        public FailarmyRepository(BlogDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }

        public Task<int> GetCountAsync(string? keyword)
        {
            return Context.Failarmies.CountAsync(x => string.IsNullOrEmpty(keyword) || x.Name.Contains(keyword));
        }

        public async Task<List<FaliarmyDto>> GetListAsync(string? keyword, int page = 1, int pageSize = 20)
        {
            var query =
                from faliarmy in Context.Failarmies.Where(x => string.IsNullOrEmpty(keyword) || x.Name.Contains(keyword))
                select new FaliarmyDto()
                {
                    Id = faliarmy.Id,
                    Description = faliarmy.Description,
                    Image = faliarmy.Image,
                    Name = faliarmy.Name
                };

            var result = await query.Skip((page - 1) * pageSize).Take(pageSize).ToArrayAsync();

            var ids = result.Select(x => x.Id).ToArray();

            var items = await Context.FailarmyItems.Where(x => ids.Contains(x.FailarmyId)).ToListAsync();

            var counts = items.GroupBy(x => x.FailarmyId).Select(x => new
            {
                Count = x.Count(),
                Id = x.First().FailarmyId,
                ids = x.Select(x=>x.ActicleId)
            }).ToArray();

            var blogIds = items.Select(x => x.ActicleId);

            var blogs = await Context.Articles.Where(x => blogIds.Contains(x.Id)).ToListAsync();

            foreach (var item in result)
            {
                var countDefault = counts.FirstOrDefault(x => x.Id == item.Id);

                item.Count = countDefault?.Count ?? 0;
                item.Values = blogs.Where(x => countDefault.ids.Contains(x.Id)).Select(x=>new GetArticleListDto()
                {
                    CategoryId = x.CategoryId,
                    Title = x.Title,
                    ReadCount = x.ReadCount,
                    Id = x.Id,
                    Like = x.Like,
                    CreationTime = x.CreationTime,
                    PublishTime = x.PublishTime,
                }).ToList();
            }

            return result.ToList();
        }
    }
}
