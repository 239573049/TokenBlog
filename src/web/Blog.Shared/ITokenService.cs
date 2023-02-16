using System.Threading.Tasks;

namespace Blog.Shared
{
    public interface ITokenService
    {
        ValueTask<string> GetTokenAsync();

        ValueTask SetToken(string value);
    }
}