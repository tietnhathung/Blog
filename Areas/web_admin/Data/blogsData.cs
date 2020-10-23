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
        public static Models.Blog find(string ID)
        {
            DataBaseBlog db = new DataBaseBlog();
            return db.Blogs.Find(ID);
        }
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
            obj.thumbnail = collection["thumbnail"];
            obj.status = 2;
            obj.create_at = DateTime.Now;
            obj.create_by = "1";


            db.Set(obj.GetType()).Add(obj);
            db.SaveChanges();

            if (collection["categories"] != null)
            {
                List<string> result = collection["categories"].Split(',').ToList();
                blog_category_Data.inserts(obj.ID, result);
            }

        }

        public static void Update(string id, FormCollection collection)
        {
            DataBaseBlog db = new DataBaseBlog();
            Models.Blog obj = db.Blogs.Find(id);

            obj.title = collection["title"];
            obj.contents = collection["contents"];
            obj.thumbnail = collection["thumbnail"];

            db.SaveChanges();

            if (collection["categories"] != null)
            {
                List<string> result = collection["categories"].Split(',').ToList();
                blog_category_Data.Update(id, result);
            }
            else
            {
                blog_category_Data.removeFromBlogId(id);
            }
            
        }

        public static void remove(string id)
        {


            DataBaseBlog db = new DataBaseBlog();
            db.Blog_category.RemoveRange(db.Blog_category.Where(x => x.blog_id == id));
            try
            {
                db.Blogs.Remove(db.Blogs.Find(id));
                db.SaveChanges();
            }
            catch
            {

            }
            
        }
    }

}