using Blog.Blog;
using Blog.ChatGPT.Dto;
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
using System.Net.Http;
using System.Net.Http.Json;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Local;
using Volo.Abp.Users;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;

namespace Blog;

[Authorize]
public class ChatGptService : ApplicationService, IChatGptService
{
    private readonly ChatGPTOptions _chatGptOptions;
    private readonly IRepository<ChatGpt> _chatGptRepository;
    private readonly ILocalEventBus _localEventBus;
    private readonly HttpClient _httpClientFactory;
    private readonly IUserInfoRepository _userInfoRepository;

    public ChatGptService(IOptions<ChatGPTOptions> chatGptOptions, IRepository<ChatGpt> chatGptRepository,
        ILocalEventBus localEventBus, IUserInfoRepository userInfoRepository, IHttpClientFactory httpClientFactory)
    {
        _chatGptOptions = chatGptOptions.Value;
        _chatGptRepository = chatGptRepository;
        _localEventBus = localEventBus;
        _userInfoRepository = userInfoRepository;
        _httpClientFactory = httpClientFactory.CreateClient();
        var token = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? _chatGptOptions.Token;

        _httpClientFactory.DefaultRequestHeaders.Remove("Authorization");

        _httpClientFactory.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
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


        var data = string.Empty;

        await _localEventBus.PublishAsync(new ChatGptEto(false, input.Message, CurrentUser.GetId()));

        var Iqueryable = await _chatGptRepository.GetQueryableAsync();

        // 获取最新的10条数据
        var list = Iqueryable.Where(x => x.UserId == CurrentUser.GetId()).OrderByDescending(x => x.CreationTime).Take(5).ToList();
        var message = list.Select(x=>x.ChatGPT? new
        {
            role="user",
            content=x.Content
        }:new
            {
                role = "assistant",
                content = x.Content
            })
            .ToList();
        
        message.Add(new
        {
            role= "user",
            content = input.Message
        });
        
        var responseMessage = await _httpClientFactory.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", new
        {
            model = "gpt-3.5-turbo",
            temperature = 0,
            max_tokens = 2560,
            user = CurrentUser.Id.Value.ToString("N"),
            messages = message
        });

        var response = await responseMessage.Content.ReadFromJsonAsync<GetChatGPTDto>();

        data = response.choices[0].message.content;

        // await foreach (var result in api.Completions.StreamCompletionEnumerableAsync(new CompletionRequest(input.Message,
        //                    model: new Model("gpt-3.5-turbo"),
        //                    temperature: 0, max_tokens: 2560)))
        // {
        //     data += result.ToString();
        // }

        await _localEventBus.PublishAsync(new ChatGptEto(true, data, CurrentUser.GetId()));

        if (!data.IsNullOrEmpty())
        {
            await _userInfoRepository.UpdateChatGptNumberAsync(CurrentUser.GetId());
        }

        return data;
    }
}