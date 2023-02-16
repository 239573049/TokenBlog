using System.Text;
using System.Web;

namespace Blog;

public static class UrlHelper
{

    public static string ToUriParam(this object obj, string url = "")
    {
        var properties = obj.GetType().GetProperties();
        StringBuilder sb = new StringBuilder();
        sb.Append(url);
        sb.Append("?");
        foreach (var p in properties)
        {
            var v = p.GetValue(obj, null);
            if (v == null)
                continue;

            sb.Append(p.Name);
            sb.Append("=");
            sb.Append(HttpUtility.UrlEncode(v.ToString()));
            sb.Append("&");
        }
        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}