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
    public class ExpenseManager : IEntityRepositoryService<Expense>, IExpenseService
    {
        EfExpenseDal _expenseDal = new EfExpenseDal();

        public void Add(Expense entity)
        {
            _expenseDal.Add(entity);
        }

        public void Delete(Expense entity)
        {
            _expenseDal.Delete(entity);
        }

        public Expense Get(Expression<Func<Expense, bool>> filter)
        {
            return _expenseDal.Get(filter);
        }

        public List<Expense> GetAll(Expression<Func<Expense, bool>> filter = null)
        {
            return _expenseDal.GetAll(filter);
        }

        public List<Expense> GetAllWithCategory(Expression<Func<Expense, bool>> filter = null)
        {
            return _expenseDal.GetAllWithCategory();
        }

        public Expense GetWithCategory(Expression<Func<Expense, bool>> filter)
        {
            return _expenseDal.GetWithCategory(filter);
        }

        public void Update(Expense entity)
        {
            _expenseDal.Update(entity);
        }
    }
}
