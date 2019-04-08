using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.DataAccess.Abstract
{
    interface IRevenueDal : IEntityRepository<Revenue>
    {
        List<Revenue> GetAllWithCategory();
        Revenue GetWithCategory(Expression<Func<Revenue, bool>> filter);
    }
}
