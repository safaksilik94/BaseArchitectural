using Safak.Core.Entities.Conrete;
using Safak.Core.Utilities.Result;
using Safak.Core.Utilities.Security.Jwt;
using Safak.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
