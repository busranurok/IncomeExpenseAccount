using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Business.Abstract
{
    public interface IUserService :IEntityRepositoryService<User>
    {
        //Bütün tiplerde geçerli olmayan metodumuz yani sadece user classı için geçerli metodtur
        bool IsExistUsername(Expression<Func<User, bool>> filter);
    }
}
