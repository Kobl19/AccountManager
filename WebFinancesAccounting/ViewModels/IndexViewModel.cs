using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFinancesAccounting.ViewModels
{
    public class IndexViewModel
    {
        public User User { get; set; }
        public List<Account> Accounts { get; set; }
    }
}