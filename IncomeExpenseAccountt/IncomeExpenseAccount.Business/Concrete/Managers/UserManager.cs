using IncomeExpenseAccount.Business.Abstract;
using IncomeExpenseAccount.DataAccess.Abstract;
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
    public class UserManager : IEntityRepositoryService<User>, IUserService
    {
        EfUserDal _userDal = new EfUserDal();

        public void Add(User entity)
        {
            _userDal.Add(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            
            return _userDal.Get(filter);
        }

        /// <summary>
        /// Veritabanından tüm userları getiren metod
        /// </summary>
        /// <param name="filter"> filtre ile çekmek istersen lambda expression kullan</param>
        /// <returns>User listesi döner</returns>
        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetAll(filter);
        }

        public bool IsExistUsername(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.IsExistUsername(filter);
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }
        //UserManager new lendiğinde bana userDal türünde nesne ver demektir.
    }
}
