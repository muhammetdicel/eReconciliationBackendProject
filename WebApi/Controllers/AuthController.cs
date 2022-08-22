using Business.Abstract;
using Entitis.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("register")]

        public IActionResult Register(UserForRegister userForRegister)
        {
            var userExists = _authService.UserExists(userForRegister.Email);
            if(!userExists.Success)
            {
                return BadRequest(userExists.Message);  
            }
            var registerResult = _authService.Register(userForRegister, userForRegister.Password);
            //var result = _authService.CreateAccessToken(registerResult.Data);
            if(registerResult.Success)
            {
                return Ok(registerResult);
            }
            return BadRequest(registerResult.Message);

        }

    }
}
