using cafe_try_two.Models;
using cafe_try_two.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace cafe_try_two.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo repository;
        public AccountController(IAccountRepo repo)
        {
            repository = repo;
        }
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUP signupModel)
        {
            var result = await repository.SignUpAsync(signupModel);
            if (result.Succeeded)
            {
                return Ok(result);

            }
            return Unauthorized();
        }

    
    }
}
