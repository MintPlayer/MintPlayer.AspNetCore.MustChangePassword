namespace MintPlayer.AspNetCore.MustChangePassword.Abstractions.Services;

public interface IMustChangePasswordService<TUser, TKey>
    where TUser : Microsoft.AspNetCore.Identity.IdentityUser<TKey>
    where TKey : IEquatable<TKey>
{
    Task ChangePasswordSignInAsync(TUser user, string oldPassword);
    Task PerformChangePasswordAsync(string newPassword, string newPasswordConfirmation);
}

