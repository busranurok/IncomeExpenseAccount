﻿using IncomeExpenseAccount.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseAccount.Entities.Concrete
{
    public class User : IEntity
    {
        [DisplayName("Kullanıcı Id")]
        public int UserId { get; set; }
        [DisplayName("Ad")]
        public String Name { get; set; }
        [DisplayName("Soyad")]
        public String Lastname { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public String Username { get; set; }
        [DisplayName("Telefon")]
        public String Phone { get; set; }
        [DisplayName("Eposta")]
        public String Email { get; set; }
        [DisplayName("Şifre")]
        public String Password { get; set; }
    }
}
