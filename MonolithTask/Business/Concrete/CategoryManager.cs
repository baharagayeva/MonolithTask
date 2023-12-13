using Business.Abstract;
using Core.Helpers;
using Core.Helpers.Constants;
using DataAccess.Abstract;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAl;

        public CategoryManager(ICategoryDAL categoryDAl)
        {
            _categoryDAl = categoryDAl;
        }//dependency injection

        public IResult Add(Category category)
        {
            _categoryDAl.Add(category);
            return new SuccessResult(CommonOperationMessages.DataAddedSuccessfully);
        }

        public IResult Delete(Category category)
        {
            _categoryDAl.Update(category);
            return new SuccessResult(CommonOperationMessages.DataDeletedSuccessfully);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDAl.GetAll().ToList());
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDAl.Get(x => x.Id == id && x.Deleted == Constant.NotDeleted));
        }

        public IResult Update(Category category)
        {
            _categoryDAl.Update(category);
            return new SuccessResult(CommonOperationMessages.DataUpdatedSuccessfully);
        }
    }
}
