using Safak.Business.Abstract;
using Safak.Business.Constants;
using Safak.Core.Utilities.Result;
using Safak.DataAccess.Abstract;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safak.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

       public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>( _productDal.Get(filter: p => p.ProductID == productId));
        }
        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(filter:p=>p.CategoryID== categoryId).ToList());
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(message: Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(message: Messages.ProductDeleted);
        }
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(message:Messages.ProductUpdated);
        }
    }
}
