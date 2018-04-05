using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Account
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        [Required(ErrorMessage = "Введите валюту")]
        [Display(Name = "Валюта*")]
        public string CurrencyName { get; set; }
        [Required(ErrorMessage = "Введите кол-во")]
        [Display(Name = "Кол-во*")]
        public double Count { get; set; }
        public DateTime Time { get; set; }
        public DateTime? DateLastChanges { get; set; }
    }
}
