using System.Data.Entity;
namespace BooksShopOnline.Models
{
    public class GiayContext : DbContext
    {
        public GiayContext() : base("BooksShopOnline")
        { }
        public DbSet<Theloai> Theloai { get; set; }
        public DbSet<Giay> Doigiay { get; set; }
    }
}