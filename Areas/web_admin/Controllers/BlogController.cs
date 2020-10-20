using Blog.Areas.web_admin.Data;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Controllers
{
    public class BlogController : BaseController
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
            List<Category> Categories = categoriesData.all();
            
            return View();
        }

        // POST: web_admin/Blog/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                 blogsData.addObject(collection);
                TempData["Msg"] = "Tạo thành công bài viết " + collection["title"];
                return RedirectToAction("Index");
            }
            catch
            {
                TempData["Msg"] = "Tạo không thành công!";
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
