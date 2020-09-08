using Safak.Business.Abstract;
using Safak.Business.Constants;
using Safak.Business.ValidationRules.FluentValidation;
using Safak.Core.Aspects.Autofact.Caching;
using Safak.Core.Aspects.Autofact.Transaction;
using Safak.Core.Aspects.Autofact.Validation;
using Safak.Core.CrossCuttingConcerns.Validation;
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
            return new SuccessDataResult<Product>(_productDal.Get(filter: p => p.ProductID == productId));
        }
        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        [CacheAspect(1)]
        public IDataResult<List<Product>> GetListListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(filter: p => p.CategoryID == categoryId).ToList());
        }
        [ValidationAspect(typeof(ProductValidator), Priority = 1)]
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
            return new SuccessResult(message: Messages.ProductUpdated);
        }

        [TransactionScopeAspect]
        public IResult TransactionOperation(Product product)
        {
            _productDal.Update(product);
            //_productDal.Add(product);
            return new SuccessResult(message: Messages.ProductUpdated);
        }
    }
}
