using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Adınız"), Required, StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Soyadınız"), Required, StringLength(50)]
        public string Surname { get; set; }


        [Display(Name = "Kullanıcı Adınız"), Required, StringLength(50)]
        public string Username { get; set; }

        [Display(Name = "Şifre"), Required, StringLength(50)]
        public string Password { get; set; }

        [Display(Name = "Telefon"), StringLength(15)]
        public string Phone { get; set; }

        [Display(Name = "Eposta"), StringLength(50)]
        [EmailAddress]
        public string Eposta { get; set; }

        [Display(Name = "Durum")]
        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
