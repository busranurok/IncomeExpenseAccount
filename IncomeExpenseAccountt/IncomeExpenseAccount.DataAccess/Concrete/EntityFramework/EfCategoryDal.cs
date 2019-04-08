using IncomeExpenseAccount.DataAccess.Abstract;
using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace IncomeExpenseAccount.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, IncomeExpenseAccountContext>, ICategoryDal
    {
        public List<Category> GetAllWithCategoryType()
        {
            List<Category> categories = new List<Category>();
            using (IncomeExpenseAccountContext context=new IncomeExpenseAccountContext())
            {
                categories = context.Categories.Include(x => x.CategoryType).ToList();
            }
            return categories;
        }

        public Category GetWithCategoryType(Expression<Func<Category, bool>> filter)
        {
            Category category = new Category();
            using (IncomeExpenseAccountContext context = new IncomeExpenseAccountContext())
            {
                category = context.Categories.Include(x=> x.CategoryType).FirstOrDefault(filter);
            }
            return category;
        }
    }
}
