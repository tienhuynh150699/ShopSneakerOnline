using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksShopOnline.Models
{
    public class Theloai
    {
        [ScaffoldColumn(false)]
        public int TheloaiID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string Tenloai { get; set; }
        public virtual ICollection<Giay> Books { get; set; }
    }
}