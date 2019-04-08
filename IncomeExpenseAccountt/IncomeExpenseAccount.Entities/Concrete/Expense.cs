using IncomeExpenseAccount.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Entities.Concrete
{
    public class Expense : IEntity
    {
        [DisplayName("Gider Id")]
        public int ExpenseId { get; set; }
        [DisplayName("Gider Ad")]
        public String ExpenseName { get; set; }
        [DisplayName("Gider Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [DisplayName("Gider Açıklama")]
        public String ExpenseDescription { get; set; }
        [DisplayName("Toplam Gider")]
        public decimal ExpenseAmount { get; set; }
        [DisplayName("Tarih")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DateTime { get; set; }

    }
}
