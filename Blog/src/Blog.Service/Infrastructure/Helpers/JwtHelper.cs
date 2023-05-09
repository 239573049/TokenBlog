using Blog.Contracts.Auth;
using Blog.Service.Domain.Users.Aggregates;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Blog.Service.Infrastructure.Helpers;

public class JwtHelper
{
    /// <summary>
    /// 生成token
    /// </summary>
    /// <param name="claimsIdentity"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static string GeneratorAccessToken(ClaimsIdentity claimsIdentity, JwtOptions options)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(options.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = claimsIdentity,
            Expires = DateTime.UtcNow.AddHours(options.EffectiveHours),
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    public static ClaimsIdentity GetClaimsIdentity(UserInfo user)
    {
        return new ClaimsIdentity(new Claim[]
        {
            new(Masa.Contrib.Authentication.Identity.ClaimType.DEFAULT_USER_NAME, user.Name),
            new(Masa.Contrib.Authentication.Identity.ClaimType.DEFAULT_USER_ID, user.Id.ToString())
        });
    }
}