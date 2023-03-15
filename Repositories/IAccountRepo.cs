using cafe_try_two.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace cafe_try_two.Repositories
{
    public interface IAccountRepo
    {
        Task<IdentityResult> SignUpAsync(SignUP signup);
    }
}
