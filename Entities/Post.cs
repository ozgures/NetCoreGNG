using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
{
    public class Post : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Başlık"), Required, StringLength(150)]
        public string Name { get; set; }

        [Display(Name = "İçerik"), Required, StringLength(50)]
        public string  Content  { get; set; }

        [Display(Name = "Resim"), StringLength(150)]
        public string Image { get; set; }

        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        //[Display(Name = "Eklenme Tarihi")]
        public DateTime ? CreateDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category  Category  { get; set; }
    }
}
