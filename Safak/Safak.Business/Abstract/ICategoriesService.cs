using Safak.Core.Utilities.Result;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.Abstract
{
    public interface ICategoriesService
    {
        IDataResult<Categories> GetById(int productId);
        IDataResult<List<Categories>> GetList();
        IResult Add(Categories Category);
        IResult Delete(Categories Category);
        IResult Update(Categories Category);
    }
}
