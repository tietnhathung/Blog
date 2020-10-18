using Blog.Areas.web_admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Controllers
{
    public class BlogController : Controller
    {
        // GET: web_admin/Blog
        public ActionResult Index()
        {
            List<Models.Blog> list = blogsData.pagination(50);
            return View(list);
        }

        // GET: web_admin/Blog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: web_admin/Blog/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: web_admin/Blog/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: web_admin/Blog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: web_admin/Blog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: web_admin/Blog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: web_admin/Blog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
