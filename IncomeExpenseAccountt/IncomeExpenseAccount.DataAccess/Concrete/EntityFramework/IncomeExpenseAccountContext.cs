using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.DataAccess.Concrete.EntityFramework
{
    public class IncomeExpenseAccountContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Revenue> Revenues { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        //connectionstring namesi yazılır, katmanlı mimaride entityframework  kullanıldığı için
        public IncomeExpenseAccountContext() : base("IncomeExpenseAccount")
        {

        }
    }
}
