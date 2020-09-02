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
    public class CategoriesManager:ICategoriesService
    {
        private ICategoriesDal _categoriesDal;

        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }

        public IDataResult<Categories> GetById(int categoriesId)
        {
            return new SuccessDataResult<Categories>(_categoriesDal.Get(filter: p => p.CategoryID == categoriesId));
        }

        public IDataResult<List<Categories>> GetList()
        {
            return new SuccessDataResult<List<Categories>>(_categoriesDal.GetList().ToList());
        }
        public IResult Add(Categories categories)
        {
            _categoriesDal.Add(categories);
            return new SuccessResult(message: Messages.ProductAdded);
        }

        public IResult Delete(Categories categories)
        {
            _categoriesDal.Delete(categories);
            return new SuccessResult(message: Messages.ProductDeleted);
        }
        public IResult Update(Categories categories)
        {
            _categoriesDal.Update(categories);
            return new SuccessResult(message: Messages.ProductUpdated);
        }
    }
}
