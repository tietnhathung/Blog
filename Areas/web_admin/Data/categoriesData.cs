using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models;

namespace Blog.Areas.web_admin.Data
{
    public class categoriesData
    {

        public static List<Category> pagination(int pana)
        {
            DataBaseBlog db = new DataBaseBlog();
            return db.Categories.OrderByDescending(c => c.create_at).Take(pana).ToList();
        }
        public static void addObject<T>(T obj)
        {
            DataBaseBlog db = new DataBaseBlog();
            
            db.Set(obj.GetType()).Add(obj);
            db.SaveChanges();
        }
        public static Category find(string id)
        {
            DataBaseBlog db = new DataBaseBlog();
            return db.Categories.Find(id);
        }

    }
}