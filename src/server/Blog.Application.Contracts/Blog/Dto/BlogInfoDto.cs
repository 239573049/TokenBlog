using System.Collections.Generic;

namespace Blog.Blog.Dto;

public class BlogInfoDto
{
    public List<CarouselDto> Carousels { get; set; } = new();

    public List<ExternalLinkDto> ExternalLinks { get; set; } = new();
}