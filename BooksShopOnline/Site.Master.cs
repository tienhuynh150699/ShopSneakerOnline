using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BooksShopOnline.Models;

namespace BooksShopOnline
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public IQueryable<Theloai> GetCategories()
        {
            var _db = new BooksShopOnline.Models.GiayContext();
            IQueryable<Theloai> query = _db.Theloai;
            return query;
        }
    }
}