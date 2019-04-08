using IncomeExpenseAccount.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Entities.Concrete
{
    public class CategoryType : IEntity
    {
        [DisplayName("Kategori Tip Id")]
        public int CategoryTypeId { get; set; }
        [DisplayName("Kategori Tip Ad")]
        public String CategoryTypeName { get; set; }
        [DisplayName("Kategori Tip Açıklama")]
        public String CategoryTypeDescription { get; set; }
    }
}
