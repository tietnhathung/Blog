using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Areas.web_admin.Data
{
    public class blog_category_Data
    {
        public static void inserts(string blogId , List<string> categoryIds){
            DataBaseBlog db = new DataBaseBlog();
            foreach ( string categoryId in categoryIds)
            {

                Blog_category bc = new Blog_category();
                bc.ID = Guid.NewGuid().ToString();
                bc.blog_id = blogId;
                bc.category_id = categoryId;
                db.Blog_category.Add(bc);
            }
            db.SaveChanges();

        }
        public static void Update(string blogId, List<string> categoryIds)
        {
            
            DataBaseBlog db = new DataBaseBlog();
            db.Blog_category.RemoveRange(db.Blog_category.Where(b => b.blog_id == blogId));
            foreach (string categoryId in categoryIds)
            {
                Blog_category bc = new Blog_category();
                bc.ID = Guid.NewGuid().ToString();
                bc.blog_id = blogId;
                bc.category_id = categoryId;
                db.Blog_category.Add(bc);
            }
            db.SaveChanges();

        }
        public static void removeFromCategory(string category_id)
        {

            DataBaseBlog db = new DataBaseBlog();
            db.Blog_category.RemoveRange(db.Blog_category.Where(b => b.category_id == category_id));
          
            db.SaveChanges();

        }
    }
}