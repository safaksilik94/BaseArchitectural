using Safak.Core.Entities.Conrete;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaim(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
