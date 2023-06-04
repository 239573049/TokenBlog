using Blog.Service.Application.Bloggers.Commands;
using Masa.BuildingBlocks.Data.UoW;

namespace Blog.Service.Application.Bloggers
{
    public class FailarmyCommandHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFailarmyRepository _failarmyRepository;

        public FailarmyCommandHandler(IFailarmyRepository failarmyRepository, IUnitOfWork unitOfWork)
        {
            _failarmyRepository = failarmyRepository;
            _unitOfWork = unitOfWork;
        }

        [EventHandler]
        public async Task CreateAsync(CreateFailarmyCommand command)
        {
            if(await _failarmyRepository.GetCountAsync(x=>x.Name == command.Dto.Name) > 0)
            {
                throw new UserFriendlyException("已经存在相同名称");
            }

            await _failarmyRepository.AddAsync(new Failarmy(command.Dto.Name, command.Dto.Description, command.Dto.Image));

            await _unitOfWork.SaveChangesAsync();
        }

        [EventHandler]
        public async Task DeleteAsync(DeleteFailarmyCommand command)
        {
            await _failarmyRepository.RemoveAsync(x => x.Id == command.id);

            await _unitOfWork.SaveChangesAsync();
        }

        [EventHandler]
        public async Task UpdateAsync(UpdateFailarmyCommand command)
        {
            var failarmy = await _failarmyRepository.FindAsync(x => x.Id == command.Dto.Id);

            if(failarmy != null)
            {
                throw new UserFriendlyException("数据不存在");
            }

            failarmy.Name = command.Dto.Name;
            failarmy.Description = command.Dto.Description;
            failarmy.Image = command.Dto.Image;

            await _failarmyRepository.UpdateAsync(failarmy);

            await _unitOfWork.SaveChangesAsync();

        }
    }
}
