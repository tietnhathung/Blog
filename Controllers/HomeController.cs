using System;
using Blog.Models;
using Blog.Prepare;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : DefaultController
    {

        public ActionResult Index()
        {
            DataBaseBlog db = new DataBaseBlog();
            List<Models.Blog> blogs = db.Blogs.ToList();
            return View(blogs);
        }

        public ActionResult BlogCategory(string searchString, int categoryID = 0)
        {
            return View();
        }

        public ActionResult Category()
        {
            List<Models.Category> cat = PrepareDB.selectListCategorys(20);
            return View(cat);
        }

        public ActionResult Detail(string ID)
        {
            Models.Blog blog = PrepareDB.selectBlog(ID);
            return View(blog);
        }
        public ActionResult searchByCategory(string id)
        {
            
            DataBaseBlog db = new DataBaseBlog();

            Category cate = db.Categories.Where(x => x.ID == id).SingleOrDefault();

            return View(cate.Blog_category.ToList());
        }

        public ActionResult searchByName(string searchString)
        {
            
            DataBaseBlog db = new DataBaseBlog();
            List<Models.Blog> listBlog = db.Blogs.Where(b => b.title.Contains(searchString)).ToList();

            return View(listBlog);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Thông tin liên hệ: 0123456789";
            return View();
        }
    }
}