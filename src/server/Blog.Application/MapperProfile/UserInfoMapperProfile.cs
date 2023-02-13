using AutoMapper;
using Blog.Blog;
using Blog.Users;

namespace Blog.MapperProfile;

public class UserInfoMapperProfile : Profile
{
    public UserInfoMapperProfile()
    {
        CreateMap<UserInfo,UserInfoDto>();
    }
}