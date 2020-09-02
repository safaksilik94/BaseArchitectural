using Safak.Core.DataAccess.EntityFramework;
using Safak.DataAccess.Abstract;
using Safak.DataAccess.Concrete.EntiyFramework.Context;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.DataAccess.Concrete.EntiyFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,SafakContext>,IProductDal
    {
    }
}
