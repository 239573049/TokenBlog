namespace Blog
{
    public static class BlogSettings
    {
        private const string Prefix = "Blog";

        public class BlogInfo
        {
            private const string GroupName = Prefix + ".BlogInfo";

            public const string Carousels = GroupName + ".Carousels";

            public const string ExternalLinks = GroupName + ".ExternalLinks";
        }
    }

}