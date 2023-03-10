namespace Blog.Auth;

public class GiteeUserInfo
{
    public string login { get; set; }
    public int id { get; set; }

    public string node_id { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string avatar_url { get; set; }

    /// <summary>
    /// github首页地址
    /// </summary>
    public string html_url { get; set; }

    public string url { get; set; }

    public string type { get; set; }
    public bool site_admin { get; set; }
    public string name { get; set; }
    public object company { get; set; }
    public string blog { get; set; }
    public string location { get; set; }
}
