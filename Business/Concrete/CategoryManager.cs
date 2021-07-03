using Business.Abstract;
using Core.Utilities.BusinessRules;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(CheckNumberOfCategories());

            if (result != null)
            {
                return result;
            }

            _categoryDal.Add(category);
            return new SuccessResult();

        }

        public IResult Delete(Category category)
        {
            throw new NotImplementedException();
        }

       
        public IResult Update(Category category)
        {
            throw new NotImplementedException();
        }

      
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }


        private IResult CheckNumberOfCategories()
        {
            var result = _categoryDal.GetAll(c => c.CategoryId != null).Count();

            if (result >= 6)
            {
                return new ErrorResult();
            }

            return new SuccessResult();

        }


    }
}
