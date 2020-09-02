using Safak.Core.Utilities.Result;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);

    }
}
