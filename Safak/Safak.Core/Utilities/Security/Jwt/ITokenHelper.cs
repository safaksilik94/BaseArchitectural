using Safak.Core.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreatToken(User user, List<OperationClaim> operationClaims);
    }
}
