namespace Blog.Service.Domain.Bloggers.Aggregates
{
    public class FailarmyItem : Entity<Guid>
    {
        public int ActicleId { get; set; }

        public Guid FailarmyId { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public int Order { get; set; }
    }
}
