using Blog.Service.Domain.Users.Aggregates;

namespace Blog.Service.Application.Users.Querues;

public record GetUserQuery() : Query<UserInfo>()
{
    public override UserInfo Result { get ; set ; }
}
