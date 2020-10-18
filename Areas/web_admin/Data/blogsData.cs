using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Data
{
    public class blogsData
    {
        public static List<Models.Blog> pagination(int pana)
        {
            DataBaseBlog db = new DataBaseBlog();
            return db.Blogs.OrderByDescending(c => c.create_at).Take(pana).ToList();
        }
        public static void addObject(FormCollection collection )
        {
            DataBaseBlog db = new DataBaseBlog();
            Models.Blog obj = new Models.Blog();



            obj.ID = Guid.NewGuid().ToString();
            obj.title = collection["title"];
            obj.contents = collection["contents"];
            obj.status = 2;
            obj.create_at = DateTime.Now;
            obj.create_by = "1";

            db.Set(obj.GetType()).Add(obj);
            db.SaveChanges();
        }
    }

}