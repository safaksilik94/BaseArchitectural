using Safak.Core.DataAccess;
using Safak.Core.Entities.Conrete;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User> 
    {
        List<OperationClaim> GetClaims(User user);
    }
}
