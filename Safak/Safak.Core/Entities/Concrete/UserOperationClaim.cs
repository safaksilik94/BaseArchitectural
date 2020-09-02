using Safak.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Core.Entities.Conrete
{
    public class UserOperationClaim:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
