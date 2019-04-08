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
    public class EfExpenseDal : EfEntityRepositoryBase<Expense, IncomeExpenseAccountContext> , IExpenseDal
    {
        public List<Expense> GetAllWithCategory(Expression<Func<Expense, bool>> filter = null)
        {
            List<Expense> expenses = new List<Expense>();

            using (IncomeExpenseAccountContext context = new IncomeExpenseAccountContext())
            {
                expenses = context.Expenses.Include(e => e.Category).ToList();
            }
            return expenses;
        }

        public Expense GetWithCategory(Expression<Func<Expense, bool>> filter)
        {
            Expense expense = new Expense();

            using (IncomeExpenseAccountContext context = new IncomeExpenseAccountContext())
            {
                expense = context.Expenses.Include(e=> e.Category).FirstOrDefault(filter);
            }
            return expense;
        }
    }
}
