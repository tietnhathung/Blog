using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Areas.web_admin.Data;

namespace Blog.Areas.web_admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: web_admin/Category
        public ActionResult Index()
        {
            List<Category> Categories = categoriesData.pagination( 50 );
            return View(Categories);
        }
        [HttpGet]
        public ActionResult SelectCategories()
        {
            List<Category> Categories = categoriesData.all();

            return Json(Categories, JsonRequestBehavior.AllowGet);
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
                Category newCa = new Category();
                newCa.ID = Guid.NewGuid().ToString();
                newCa.name = collection["name"];
                newCa.description = collection["description"];
                newCa.create_at = DateTime.Now;
                newCa.create_by = "1";

                categoriesData.addObject(newCa);
                TempData["Msg"] = "Tạo thành công thể loại " + newCa.name;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: web_admin/Category/Edit/5
        public ActionResult Edit(string id)
        {
            Category cat = categoriesData.find(id);
            return View(cat);
        }

        // POST: web_admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                Category newCa = new Category();
                newCa.ID = collection["ID"];
                newCa.name = collection["name"];
                newCa.description = collection["description"];

                categoriesData.update(newCa);
                TempData["Msg"] = "Cập nhật thành công thể loại " + newCa.name;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: web_admin/Category/Delete/5
        public ActionResult Delete(string id)
        {
            Category cat = categoriesData.find(id);
            return View(cat);
        }

        // POST: web_admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection obj)
        {
            try
            {
                categoriesData.remove(obj["ID"]);
                TempData["Msg"] = "Xóa thành công thể loại " + obj["name"];
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
