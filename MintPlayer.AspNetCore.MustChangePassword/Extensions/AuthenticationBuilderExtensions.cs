using Microsoft.AspNetCore.Authentication;

namespace MintPlayer.AspNetCore.MustChangePassword.Extensions;

public static class AuthenticationBuilderExtensions
{
    public static AuthenticationBuilder AddMustChangePasswordUserIdCookie(this AuthenticationBuilder builder)
    {
        return builder.AddCookie(Constants.MustChangePasswordConstants.MustChangePasswordScheme, o =>
        {
            o.Cookie.Name = Constants.MustChangePasswordConstants.MustChangePasswordScheme;
            o.ExpireTimeSpan = TimeSpan.FromMinutes(5);
        });
    }
}
