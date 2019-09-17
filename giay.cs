using System;
namespace BookShopOnline.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string Tengiay { get; set; }
        [Required, StringLength(1000), Display(Name = "Mieu ta"),
        DataType(DataType.MultilineText)]
        public string Mieuta { get; set; }
        public string Image { get; set; }
        [Display(Name = "Gia tien")]
        public float? UnitPrice { get; set; }
        public int? TheloaiID { get; set; }
        public virtual Theloai Theloai { get; set; }
    }
}



