using IncomeExpenseAccount.DataAccess.Abstract;
using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, IncomeExpenseAccountContext>, IUserDal
    {
        public bool IsExistUsername(Expression<Func<User, bool>> filter)
        {
            bool result = false;
            using (IncomeExpenseAccountContext context = new IncomeExpenseAccountContext())
            {
                result = context.Users.FirstOrDefault(filter) == null ? false : true;
            }
            return result;
        }
    }
}
