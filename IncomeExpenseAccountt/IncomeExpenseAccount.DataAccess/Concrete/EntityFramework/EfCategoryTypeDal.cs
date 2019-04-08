using IncomeExpenseAccount.DataAccess.Abstract;
using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryTypeDal : EfEntityRepositoryBase<CategoryType, IncomeExpenseAccountContext>, ICategoryTypeDal
    {
    }
}
