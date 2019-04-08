using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Business.Abstract
{
    public interface ICategoryService : IEntityRepositoryService<Category>
    {
        List<Category> GetAllWithCategoryType();
        Category GetWithCategoryType(Expression<Func<Category, bool>> filter);
    }
}
