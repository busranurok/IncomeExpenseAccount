using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Business.Abstract
{
    public interface IEntityRepositoryService<T>
    {
        //NOT: Bütün classlarda kullanılacak ortak metod imzalarıdır!
        //List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //T Get(int id);
        T Get(Expression<Func<T, bool>> filter);
        //void Add(User user);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
