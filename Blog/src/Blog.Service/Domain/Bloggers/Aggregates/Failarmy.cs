namespace Blog.Service.Domain.Bloggers.Aggregates
{
    public class Failarmy : Entity<Guid>
    {
        protected Failarmy()
        {
        }

        public Failarmy(string name, string description, string image)
        {
            Name = name;
            Description = description;
            Image = image;
            Id = Guid.NewGuid();
        }



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
