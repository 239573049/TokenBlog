using Blog.Eto;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus;
using Volo.Abp.Uow;

namespace Blog;

[UnitOfWork]
public class ChatGptEventBusHandle : ILocalEventHandler<ChatGptEto>, ITransientDependency
{
    private readonly IRepository<ChatGpt> _chatGptRepository;

    public ChatGptEventBusHandle(IRepository<ChatGpt> chatGptRepository)
    {
        _chatGptRepository = chatGptRepository;
    }

    public async Task HandleEventAsync(ChatGptEto eventData)
    {
        await _chatGptRepository.InsertAsync(new ChatGpt()
        {
            ChatGPT = eventData.ChatGPT,
            Content = eventData.Content,
            CreatedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            UserId = eventData.UserId
        });
    }
}