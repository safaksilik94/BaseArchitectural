using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Safak.Business.Abstract;
using Safak.Entities.Dtos;

namespace Safak.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authSerice;

        public AuthController(IAuthService authService)
        {
            _authSerice = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userLoginInfoDto)
        {
            var userToLogin = _authSerice.Login(userLoginInfoDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authSerice.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authSerice.UserExists(userForRegisterDto.Email);
            if(!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }
            //password fazla gitti
            var registerResult = _authSerice.Register(userForRegisterDto,userForRegisterDto.Password);
            var result = _authSerice.CreateAccessToken(registerResult.Data);
            if(result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

    }
}
