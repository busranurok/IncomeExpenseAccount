using IncomeExpenseAccount.Business.Abstract;
using IncomeExpenseAccount.DataAccess.Concrete.EntityFramework;
using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Business.Concrete
{
    public class CategoryManager : IEntityRepositoryService<Category>, ICategoryService
    {
        EfCategoryDal _categoryDal = new EfCategoryDal();
        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            var category = _categoryDal.Get(filter);
            return category;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            var categories = _categoryDal.GetAll(filter);
            return categories;
        }

        public List<Category> GetAllWithCategoryType()
        {
            return _categoryDal.GetAllWithCategoryType();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }

        public Category GetWithCategoryType(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.GetWithCategoryType(filter);
        }
    }
}
