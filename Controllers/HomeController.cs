using System;
using Blog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            DataBaseBlog db = new DataBaseBlog();
            List<Models.Blog> blogs = db.Blogs.ToList();
            return View(blogs);
        }

        //public ActionResult BlogCategory(string searchString, int categoryID = 0)
        //{
        //    List<Models.Blog> blogs = PrepareDB.selectListBlogs(20);

        //    var categories = from c in mydb.Categories select c;
        //    ViewBag.categoryID = new SelectList(categories, "ID", "name");

        //    var blogs = from b in mydb.Blogs
        //                join c in mydb.Categories on b.ID equals c.ID
        //                select new { b.ID, b.title, b.contents, c.ID, c.name };

        //    if (categoryID != 0)
        //    {
        //        blogs = blogs.Where(x => x.CategoryID == categoryID);
        //    }

        //    List<Models.Blog> listBlogs = new List<Models.Blog>();
        //    foreach (var item in blogs)
        //    {
        //        Blog temp = new Blog();
        //        temp.CategoryID = item.CategoryID;
        //        temp.name = item.name;
        //        temp.contents = item.contents;
        //        temp.ID = item.ID;
        //        temp.title = item.title;
        //        listBlogs.Add(temp);
        //    }

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        blogs = Blogs.Where(s => s.title.Contains(searchString));
        //    }

        //    return View(listBlogs);
        //}

        //public ActionResult Category()
        //{
        //    List<Models.Category> cat = PrepareDB.selectListCategorys(20);
        //    return View(cat);
        //}

        //public ActionResult Detail(string ID)
        //{
        //    Models.Blog blog = PrepareDB.selectBlog(ID);
        //    return View(blog);
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";
        //    return View();
        //}

        //public ActionResult searchBlogs(string ID)
        //{
        //    List<Models.Blog> blogs = PrepareDB.selectListBlogs(20);

        //    if (!String.IsNullOrEmpty(ID))
        //    {
        //        blogs = Blogs.Where(s => s.title.Contains(ID));
        //    }

        //    return View(blogs);
        //}
    }
}