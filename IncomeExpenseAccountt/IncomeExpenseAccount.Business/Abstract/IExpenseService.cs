using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Business.Abstract
{
    public interface IExpenseService : IEntityRepositoryService<Expense>
    {
        List<Expense> GetAllWithCategory(Expression<Func<Expense, bool>> filter = null);
        Expense GetWithCategory(Expression<Func<Expense, bool>> filter);
    }
}
