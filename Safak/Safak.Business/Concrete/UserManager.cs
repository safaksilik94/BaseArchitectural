using Safak.Business.Abstract;
using Safak.Core.Entities.Conrete;
using Safak.DataAccess.Abstract;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
           return _userDal.Get(filter: u => u.Email == email);
        }

        public List<OperationClaim> GetClaim(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
