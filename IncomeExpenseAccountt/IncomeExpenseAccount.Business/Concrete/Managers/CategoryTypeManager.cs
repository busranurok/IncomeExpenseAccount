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
    public class CategoryTypeManager : IEntityRepositoryService<CategoryType>, ICategoryTypeService
    {
        EfCategoryTypeDal _categoryTypeDal = new EfCategoryTypeDal();
        public void Add(CategoryType entity)
        {
            _categoryTypeDal.Add(entity);
        }

        public void Delete(CategoryType entity)
        {
            _categoryTypeDal.Delete(entity);
        }

        public void Update(CategoryType entity)
        {
            _categoryTypeDal.Update(entity);
        }

        public CategoryType Get(Expression<Func<CategoryType, bool>> filter)
        {
            return _categoryTypeDal.Get(filter);
        }

        //Not: filter ı null yaptığımızda metodu çağırdığımızda parametre olarak bir şey girmesek de gelir.
        public List<CategoryType> GetAll(Expression<Func<CategoryType, bool>> filter = null)
        {
            return _categoryTypeDal.GetAll(filter);
        }
    }
}
