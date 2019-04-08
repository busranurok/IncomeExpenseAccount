using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncomeExpenseAccountt.Models
{
    public class CategoryAddViewModel
    {
        public Category Category { get; set; }
        //Ekranda Category verilerinin dışında başka veriler de görülmesini istiyosak yani genişletilebilir olsun  istiyor isek böyle bir model olulturmamız gerekir.Aksi takdirde veritabanı üzerinde değişiklik yapmamız gerekir.
        //public string Name { get; set; }

        public CategoryAddViewModel()
        {
            this.Category = new Category();
        }
    }
}