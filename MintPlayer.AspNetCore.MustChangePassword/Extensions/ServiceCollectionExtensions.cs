using MintPlayer.AspNetCore.MustChangePassword.Services;
using MintPlayer.AspNetCore.MustChangePassword.Abstractions.Services;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMustChangePassword<TUser, TKey>(this IServiceCollection services)
        where TUser : Microsoft.AspNetCore.Identity.IdentityUser<TKey>
        where TKey : IEquatable<TKey>
    {
        return services.AddScoped<IMustChangePasswordService<TUser, TKey>, MustChangePasswordService<TUser, TKey>>();
    }
}
