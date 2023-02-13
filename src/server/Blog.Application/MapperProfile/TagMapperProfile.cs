using AutoMapper;
using Blog.Blog;
using Blog.Blog.Dto;

namespace Blog.MapperProfile;

public class TagMapperProfile : Profile
{
    public TagMapperProfile()
    {
        CreateMap<Tag, TagDto>();
    }
}