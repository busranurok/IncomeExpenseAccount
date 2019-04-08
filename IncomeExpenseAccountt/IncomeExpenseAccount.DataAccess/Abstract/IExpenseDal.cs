using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.DataAccess.Abstract
{
    public interface IExpenseDal : IEntityRepository<Expense>
    {
        List<Expense> GetAllWithCategory(Expression<Func<Expense, bool>> filter = null);
        Expense GetWithCategory(Expression<Func<Expense, bool>> filter);
    }
}
