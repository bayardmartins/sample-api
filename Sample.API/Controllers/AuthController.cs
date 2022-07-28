using Microsoft.AspNetCore.Mvc;
using Sample.API.Helper;
using Sample.API.Interfaces;
using Sample.API.Models;
using Sample.API.Service;

namespace Sample.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IUserService _userService;

        public AuthController(ILogger<MovieController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        /// <summary>
        /// Login user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Bearer token</returns>
        [HttpPost("auth")]
        public ActionResult<dynamic> Authenticate(User user)
        {
            User? userFound = _userService.GetUserByLogin(user.Login);
            if (userFound == null) return NotFound(Constants.UserNotFound);
            if (!userFound.Password.Equals(user.Password)) return BadRequest(Constants.WrongPassword);
            var token = TokenHelper.GenerateToken(userFound);

            return new
            {
                user = userFound.Login,
                token = token
            };
        }
    }
}
