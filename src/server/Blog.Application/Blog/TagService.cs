using Blog.Dto;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Blog.Blog;

public class TagService : ApplicationService, ITagService
{
    private readonly IRepository<Tag> _tagRepository;

    public TagService(IRepository<Tag> tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public async Task<List<TagDto>> GetListAsync()
    {
        var tags = await _tagRepository.GetListAsync();

        return ObjectMapper.Map<List<Tag>, List<TagDto>>(tags);
    }

    public async Task CreateAsync(TagDto input)
    {
        if (await _tagRepository.AnyAsync(x => x.Title == input.Title))
        {
            throw new BusinessException(message: "标签名称存在");
        }

        await _tagRepository.InsertAsync(new Tag(input.Title)
        {
            Rank = input.Rank
        });
    }
}