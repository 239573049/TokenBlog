using AutoMapper;
using Blog.Component.Pages.Module;

namespace Blog.MapperProfile;

public class ChatGptMapperfile : Profile
{
    public ChatGptMapperfile()
    {
        CreateMap<ChatGpt, ChatGptDto>();
    }
}
