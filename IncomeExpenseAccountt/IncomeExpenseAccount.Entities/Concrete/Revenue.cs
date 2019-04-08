using IncomeExpenseAccount.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Entities.Concrete
{
    public class Revenue : IEntity
    {
        [DisplayName("Gelir Id")]
        public int RevenueId { get; set; }
        [DisplayName("Gelir Ad")]
        public String RevenueName { get; set; }
        [DisplayName("Gelir Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [DisplayName("Gelir Açıklama")]
        public String RevenueDescription { get; set; }
        [DisplayName("Toplam Gelir")]
        public decimal RevenueAmount { get; set; }
        [DisplayName("Tarih")]
        public DateTime DateTime { get; set; }
    }
}
