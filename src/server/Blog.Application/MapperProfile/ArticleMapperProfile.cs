using AutoMapper;
using Blog.Blog;
using Blog.Blog.Dto;
using Blog.Dto;

namespace Blog.MapperProfile;

public class ArticleMapperProfile : Profile
{
    public ArticleMapperProfile()
    {
        CreateMap<Article, ArticlesDto>();
        CreateMap<ArticleView, GetArticlesDto>();
    }
}