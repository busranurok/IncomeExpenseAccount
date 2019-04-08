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
    public class RevenueManager : IEntityRepositoryService<Revenue>, IRevenueService
    {
        EfRevenueDal _revenueDal = new EfRevenueDal();

        public void Add(Revenue entity)
        {
            _revenueDal.Add(entity);
        }

        public void Delete(Revenue entity)
        {
            _revenueDal.Delete(entity);
        }

        public Revenue Get(Expression<Func<Revenue, bool>> filter)
        {
            return _revenueDal.Get(filter);
        }

        public List<Revenue> GetAll(Expression<Func<Revenue, bool>> filter = null)
        {
            return _revenueDal.GetAll();
        }

        public List<Revenue> GetAllWithCategory()
        {
            return _revenueDal.GetAllWithCategory();
        }

        public Revenue GetWithCategory(Expression<Func<Revenue, bool>> filter)
        {
            return _revenueDal.GetWithCategory(filter);
        }

        public void Update(Revenue entity)
        {
            _revenueDal.Update(entity);
        }
    }
}
