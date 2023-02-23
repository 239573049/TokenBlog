using Blog.Blog;
using Blog.Component.Pages.Module;
using Blog.Eto;
using Blog.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Local;
using Volo.Abp.Users;

namespace Blog;

[Authorize]
public class ChatGptService : ApplicationService, IChatGptService
{
    private readonly ChatGPTOptions _chatGptOptions;
    private readonly IRepository<ChatGpt> _chatGptRepository;
    private readonly ILocalEventBus _localEventBus;
    private readonly IUserInfoRepository _userInfoRepository;

    public ChatGptService(IOptions<ChatGPTOptions> chatGptOptions, IRepository<ChatGpt> chatGptRepository, ILocalEventBus localEventBus, IUserInfoRepository userInfoRepository)
    {
        _chatGptOptions = chatGptOptions.Value;
        _chatGptRepository = chatGptRepository;
        _localEventBus = localEventBus;
        _userInfoRepository = userInfoRepository;
    }

    public async Task<List<ChatGptDto>> GetListAsync()
    {
        var data = await _chatGptRepository.GetListAsync(x => x.UserId == CurrentUser.GetId());

        return ObjectMapper.Map<List<ChatGpt>, List<ChatGptDto>>(data.OrderBy(x => x.CreationTime).ToList());
    }

    public async Task<string> PostResponse(PostResponseInput input)
    {
        var userInfo = await _userInfoRepository.FirstOrDefaultAsync(x => x.Id == CurrentUser.Id);

        if (userInfo.ChatGptNumber <= 0)
        {
            throw new BusinessException(code: BlogDomainErrorCodes.NotSufficientFunds);
        }

        var token = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? _chatGptOptions.Token;

        var api = new OpenAIAPI(token);

        var data = string.Empty;

        await _localEventBus.PublishAsync(new ChatGptEto(false, input.Message, CurrentUser.GetId()));

        await foreach (var result in api.Completions.StreamCompletionEnumerableAsync(new CompletionRequest(input.Message,
                           model: Model.DavinciText,
                           temperature: 1, max_tokens: 1000)))
        {
            data += result.ToString();
        }

        await _localEventBus.PublishAsync(new ChatGptEto(true, data, CurrentUser.GetId()));

        if (!data.IsNullOrEmpty())
        {
            await _userInfoRepository.UpdateChatGptNumberAsync(CurrentUser.GetId());
        }
        return data;
    }
}