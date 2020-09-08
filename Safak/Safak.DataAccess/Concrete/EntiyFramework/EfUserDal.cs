using Safak.Core.DataAccess.EntityFramework;
using Safak.DataAccess.Abstract;
using Safak.DataAccess.Concrete.EntiyFramework.Context;
using System.Linq;
using System.Collections.Generic;
using Safak.Core.Entities.Conrete;

namespace Safak.DataAccess.Concrete.EntiyFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, SafakContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using(var context=new SafakContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                if (result == null) { }
                return result.ToList();
            }
        }
    }
}
