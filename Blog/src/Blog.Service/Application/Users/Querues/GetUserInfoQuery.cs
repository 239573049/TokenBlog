using Blog.Service.Domain.Users.Aggregates;

namespace Blog.Service.Application.Users.Querues;

public record GetUserInfoQuery(string account, string password) : Query<UserInfo>()
{
    public override UserInfo Result { get; set; }
}
