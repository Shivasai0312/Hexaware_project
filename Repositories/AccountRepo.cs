using cafe_try_two.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebAPIwithIdentity.Models;

namespace cafe_try_two.Repositories
{
    public class AccountRepo:IAccountRepo
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountRepo(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> SignUpAsync(SignUP signup)
        {
            var user = new ApplicationUser()
            {
                Name = signup.Name,
                Email = signup.Email,
                UserName = signup.Email

            };
            return await _userManager.CreateAsync(user, signup.Password);

        }
    }
}
