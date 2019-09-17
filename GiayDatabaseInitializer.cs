using System.Data.Entity;
namespace BooksShopOnline.Models
{
    public class GiayDatabaseInitializer : DropCreateDatabaseAlways<GiayContext>
    {
        protected override void Seed(GiayContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
 new Theloai
 {
 TheloaiID = 1,
Tenloai = "Fiction"
 },
 new Theloai
 {
 TheloaiID = 2,
Tenloai = "Biographies and Memoirs"
 },
 new Theloai{
 TheloaiID = 3,
Tenloai = "Biological Sciences"
 },
 new Theloai
 {
 TheloaiID = 4,
Tenloai = "Self-Help"
 }
 };
            return categories;
        }
        private static List<Giay> GetBooks()
        {
            var books = new List<Giay> {
 //book 1
 new Giay
 {
 ID = 1,
Tengiay = "Sneaker Nam",
Mieuta = "Adiddas fiction",
ImagePath = "Pic1.png",
Giatien = 15f,
 TheloaiID = 1
        },
 //Giay 2
 new Giay
 {
 ID = 2,
 Tengiay = "Sneaker Nu",
 Mieuta = "Nike Real",
 Image="Pic2.png",
Giatien = 10f,
TheloaiID = 2
 },
 //Giay 3
 new Giay
 {
 ID = 3,
Tengiay = "Unisex",
Mieuta = "Sneaker Nam",
Image="Pic3.png",
Giatien = 20f,
TheloaiID = 3
 },
 //Giay 4
 new Giay
 {
ID = 4,
Tengiay = "Korea",
Mieuta = "Sneaker Nu",
 Image= "Pic6.png",
Giatien = 16f,
TheloaiID = 4
 },
 };
 return Giay;
 }
 }
}