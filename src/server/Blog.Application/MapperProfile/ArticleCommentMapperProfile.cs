using AutoMapper;
using Blog.Blog;
using Blog.Blog.Dto;

namespace Blog.MapperProfile;

public class ArticleCommentMapperProfile : Profile
{
    public ArticleCommentMapperProfile()
    {
        CreateMap<ArticleCommentView, GetArticleCommentDto>();
    }
}