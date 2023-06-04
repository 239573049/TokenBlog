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

            var counts = await Context.FailarmyItems.Where(x => ids.Contains(x.FailarmyId)).GroupBy(x => x.FailarmyId).Select(x => new
            {
                Count = x.Count(),
                Id = x.First().FailarmyId
            }).ToArrayAsync();

            foreach (var item in result)
            {
                item.Count = counts.FirstOrDefault(x => x.Id == item.Id)?.Count ?? 0;
            }

            return result.ToList();
        }
    }
}
