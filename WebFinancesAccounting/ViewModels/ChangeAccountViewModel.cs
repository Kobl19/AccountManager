using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFinancesAccounting.ViewModels
{
    public class ChangeAccountViewModel
    {
        public int UserId { get; set; }
        public int AccountId { get; set; }
        [Display(Name = "Кол-во")]
        public double Count { get; set; }
        [Display(Name = "Валюта")]
        public string Name { get; set; }
    }
}