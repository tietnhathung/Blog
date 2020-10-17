using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: web_admin/Category
        public ActionResult Index()
        {
            DataBaseBlog db = new DataBaseBlog();

            List<Category> Categories = db.Categories.ToList();
            return View(Categories);
        }

        // GET: web_admin/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: web_admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: web_admin/Category/Create
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

        // GET: web_admin/Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: web_admin/Category/Edit/5
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

        // GET: web_admin/Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: web_admin/Category/Delete/5
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
