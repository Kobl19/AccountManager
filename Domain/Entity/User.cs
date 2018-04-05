using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [MetadataType(typeof(UserMetadata))]
    public  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        [Display(Name = "ФИО")]
        public string FIO
        {
            get
            {
                return String.Format("{0} {1}", this.LastName, this.FirstName);
            }
        }
        // Добавление валидации
        public class UserMetadata
        {
            [Required(ErrorMessage = "Введите Имя")]
            [Display(Name = "Имя*")]
            public string FirstName;

            [Required(ErrorMessage = "Введите Фамилию")]
            [Display(Name = "Фамилия*")]
            public string LastName;

            [Display(Name = "Дата регистрации")]
            public DateTime CreateDate;
        }
    }
}
