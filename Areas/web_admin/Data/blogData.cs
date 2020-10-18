using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Bloger.Areas.web_admin.Data
{
    public class blogData
    {
        public static List<Blog> pagination(int pana)
        {
            DataBaseBlog db = new DataBaseBlog();
            return db.Blogs.OrderByDescending(c => c.create_at).Take(pana).ToList();
        }
    }
}