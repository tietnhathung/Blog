using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Areas.web_admin.Data
{
    public class blogsData
    {
        public static List<Models.Blog> pagination(int pana)
        {
            DataBaseBlog db = new DataBaseBlog();
            return db.Blogs.OrderByDescending(c => c.create_at).Take(pana).ToList();
        }
    }

}