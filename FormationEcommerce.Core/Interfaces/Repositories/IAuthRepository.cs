using FormationEcommerce.Core.Entities.Identity;
using FormationEcommerce.Core.Interfaces.Repositories.Base;
using Microsoft.AspNetCore.Identity;

namespace FormationEcommerce.Core.Interfaces.Repositories
{
    public interface IAuthRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser?> GetUserByEmailAsync(string email);

        Task<ApplicationUser?> GetUserByUserNameAsync(string userName);

        /*To check with Oussama if we need to add the following method because we already have
        a method in the base repository that does the same thing*/

        Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password);

        Task<bool> CheckPasswordAsync(ApplicationUser user, string password);

        Task<IList<string>> GetUserRolesAsync(ApplicationUser user);

        Task<bool> RoleExistsAsync(string roleName);

        Task<IdentityResult> CreateRoleAsync(string roleName);

        Task<IdentityResult> AddUserToRoleAsync(ApplicationUser user, string roleName);
    }
}