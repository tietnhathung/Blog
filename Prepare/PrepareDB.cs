using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models;


namespace Blog.Prepare
{
    public class PrepareDB
    {
        public static List<Models.Category> selectListCategorys(int total)
        {
            DataBaseBlog mydb = new DataBaseBlog();
            return mydb.Categories.ToList();
        }

        public static List<Models.Blog> selectListBlogs(int total)
        {
            DataBaseBlog mydb = new DataBaseBlog();
            return mydb.Blogs.ToList();
        }

        public static Models.Blog selectBlog(string ID)
        {
            DataBaseBlog mydb = new DataBaseBlog();
            return mydb.Blogs.Find(ID);
        }
    }
}