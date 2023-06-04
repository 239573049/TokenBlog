namespace Blog.Contracts.Blogger
{
    public class CreateFailarmyDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }
    }
}
