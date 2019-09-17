using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BooksShopOnline.Models;
using System.Web.ModelBinding;

namespace BooksShopOnline
{
    public partial class GiayList : System.Web.UI.Page
    {
        public int? TheloaiID { get; internal set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public IQueryable<GiayList> GetBooks([QueryString("id")] int? TheloaiId)
        {
            var _db = new BooksShopOnline.Models.GiayContext();
            IQueryable<GiayList> query = _db.Giay;
            if (TheloaiId.HasValue && TheloaiId > 0)
            {
                query = query.Where(p => p.TheloaiID == TheloaiId);
            }
            return query;
        }
    }
}