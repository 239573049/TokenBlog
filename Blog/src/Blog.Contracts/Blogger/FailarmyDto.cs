namespace Blog.Contracts.Blogger
{
    public class FaliarmyDto : CreateFailarmyDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 博客列表
        /// </summary>
        public List<GetArticleListDto> Values { get; set; } = new();
    }
}
