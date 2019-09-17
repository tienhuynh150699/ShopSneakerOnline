using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using Microsoft.Build.Framework.XamlTypes;

namespace BooksShopOnline.Models
{
    public class GiayContext : DbContext
    {
        public GiayContext() : base("BooksShopOnline")
        { }
        public DbSet<Theloai> Theloai { get; set; }
        public DbSet<Giay> DoiGiay { get; set; }
        public IQueryable<Category> Categories { get; internal set; }
        public IQueryable<GiayList> Giay { get; internal set; }
    }
}