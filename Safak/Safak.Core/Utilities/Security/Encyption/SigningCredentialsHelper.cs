﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Core.Utilities.Security.Encyption
{
    public class SigningCredentialsHelper
    {
       public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, algorithm: SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
