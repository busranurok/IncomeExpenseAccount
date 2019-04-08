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
    public class EfRevenueDal : EfEntityRepositoryBase<Revenue, IncomeExpenseAccountContext>, IRevenueDal
    {
        //sadece bu class a özel metodlar yazılır.
        public List<Revenue> GetAllWithCategory()
        {
            List<Revenue> revenues = new List<Revenue>();
            using (IncomeExpenseAccountContext context = new IncomeExpenseAccountContext())
            {
                revenues = context.Revenues.Include(x=> x.Category).ToList();
            }
            return revenues;
        }

        public Revenue GetWithCategory(Expression<Func<Revenue, bool>> filter)
        {
            Revenue revenue = new Revenue();
            using (IncomeExpenseAccountContext context = new IncomeExpenseAccountContext())
            {
                revenue = context.Revenues.Include(r => r.Category).FirstOrDefault(filter);
            }
            return revenue;
        }
    }
}
