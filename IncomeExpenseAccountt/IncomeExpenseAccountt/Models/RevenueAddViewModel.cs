using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncomeExpenseAccountt.Models
{
    public class RevenueAddViewModel
    {
        public Revenue Revenue { get; set; }

        public RevenueAddViewModel()
        {
            this.Revenue = new Revenue();
        }
    }
}