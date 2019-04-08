using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.DataAccess.Abstract
{
    public interface ICategoryTypeDal : IEntityRepository<CategoryType>
    {
    }
}
