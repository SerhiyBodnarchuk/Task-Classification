using Microsoft.AspNetCore.Mvc;
using TaskClassification.Api.Models.Auth;
using TaskClassification.Business.Features.Authentication.Abstract;
using TaskClassification.Business.Features.User.Abstract;

namespace TaskClassification.Api.Controllers
{
    public class AuthenticationController : BaseApiController
    {
        private readonly IAuthManager _authManager;
        private readonly IUserService _userService;

        public AuthenticationController(IAuthManager authManager, IUserService userService)
        {
            _authManager = authManager;
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _authManager.AuthenticateAsync(model.Username, model.Password);

            return result.IsSuccessful ? 
                Ok(result.Result) : 
                Unauthorized(result.Message);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var result = await _userService.CreateUserAsync(model.Username, model.Email, model.Password, model.Role);

            return result.IsSuccessful ?
                Ok() : 
                StatusCode(StatusCodes.Status500InternalServerError, result.Message);
        }
    }
}
