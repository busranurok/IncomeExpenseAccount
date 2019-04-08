using IncomeExpenseAccount.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Entities.Concrete
{
    public class Category : IEntity
    {
        [DisplayName("Kategori Id")]
        public int CategoryId { get; set; }
        [DisplayName("Kategori Ad")]
        public String CategoryName { get; set; }
        [DisplayName("Kategori Açıklama")]
        public String CategoryDescription { get; set; }
        [DisplayName("Kategori")]
        public int CategoryTypeId { get; set; }
        [DisplayName("Kategori Tipi")]
        public virtual CategoryType CategoryType { get; set; }
    }
}
