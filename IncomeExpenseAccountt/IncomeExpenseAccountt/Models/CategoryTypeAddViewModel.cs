using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncomeExpenseAccountt.Models
{
    public class CategoryTypeAddViewModel
    {
        public CategoryType CategoryType { get; set; }

        public CategoryTypeAddViewModel()
        {
            this.CategoryType = new CategoryType();
        }
    }
}