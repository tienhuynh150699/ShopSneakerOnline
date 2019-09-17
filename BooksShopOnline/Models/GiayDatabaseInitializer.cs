using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
namespace BooksShopOnline.Models
{
    public class GiayDatabaseInitializer : DropCreateDatabaseAlways<GiayContext>
    {
        public static List<Giay> Giay { get; private set; }

        protected override void Seed(GiayContext context)
        {
            GetCategories().ForEach(c => context.Theloai.Add(c));
        }
        private static List<Theloai> GetCategories()
        {
            var Theloai = new List<Theloai> {
            
 new Theloai
 {
 TheloaiID = 1,
Tenloai = "Adidas"
 },
 new Theloai
 {
 TheloaiID = 2,
Tenloai = "Nike"
 },
 new Theloai{
 TheloaiID = 3,
Tenloai = "Sneaker"
 },
 new Theloai
 {
 TheloaiID = 4,
Tenloai = "Biti's"
 }
 };
            return Theloai;
        }
        private static List<Giay> GetBooks()
        {
            var books = new List<Giay> {
 //book 1
 new Giay
 {
 ID = 1,
Tengiay = "Sneaker Nam",
Mieuta = "Adidas fiction",
ImagePath = "pic1.jpg",
Giatien = 15f,
 TheloaiID = 1
        },
 //Giay 2
 new Giay
 {
 ID = 2,
 Tengiay = "Sneaker Nu",
 Mieuta = "Nike Real",
 ImagePath="pic2.jpg",
Giatien = 10f,
TheloaiID = 2
 },
 //Giay 3
 new Giay
 {
 ID = 3,
Tengiay = "Unisex",
Mieuta = "Sneaker Nam",
ImagePath= "pic3.jpg",
Giatien = 20f,
TheloaiID = 3
 },
 //Giay 4
 new Giay
 {
ID = 4,
Tengiay = "Korea",
Mieuta = "Sneaker Nu",
 ImagePath= "pic6.jpg",
Giatien = 16f,
TheloaiID = 4
 },
 };
            return Giay;
        }
    }
}
