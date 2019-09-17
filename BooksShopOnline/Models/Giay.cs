using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksShopOnline.Models
{
    public class Giay
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string Tengiay { get; set; }
        [Required, StringLength(1000), Display(Name = "Mieu ta"),
        DataType(DataType.MultilineText)]
        public string Mieuta { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Gia tien")]
        public float? Giatien { get; set; }
        public int? TheloaiID { get; set; }
        public virtual Theloai Theloai { get; set; }
    }
}