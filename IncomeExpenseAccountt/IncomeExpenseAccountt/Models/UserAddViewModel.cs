using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncomeExpenseAccountt.Models
{
    public class UserAddViewModel
    {
        public User User { get; set; }

        //NOT: UserAddViewModel in nesnesi tanımlandığında User propertisi null gelmesin diye yaparız.!
        public UserAddViewModel()
        {
            this.User = new User();
        }
    }
}