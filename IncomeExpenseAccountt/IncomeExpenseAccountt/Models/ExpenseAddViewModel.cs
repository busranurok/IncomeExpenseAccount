using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncomeExpenseAccountt.Models
{
    public class ExpenseAddViewModel
    {
        public Expense Expense { get; set; }

        public ExpenseAddViewModel()
        {
            this.Expense = new Expense();
        }
    }
}