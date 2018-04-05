using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFinancesAccounting.ViewModels
{
    public class AddAcountViewModel
    {
        public int UserId { get; set;}
        public Account Account { get; set; }
    }
}