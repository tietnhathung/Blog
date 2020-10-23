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
            ViewBag.listCategories = Categories;
            return View();
        }

        // POST: web_admin/Blog/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var section = (UserSection)Session[Constants.USER_SECTION];

                    blogsData.addObject(collection, section);
                    TempData["Msg"] = "Tạo thành công bài viết " + collection["title"];
                    return RedirectToAction("Index");
                }
                catch
                {
                    TempData["Msg"] = "Tạo không thành công!";
                    return View();
                }
            }
            else
            {
                return View();
            }

        }

        // GET: web_admin/Blog/Edit/5
        public ActionResult Edit(string id)
        {
            Models.Blog bl = blogsData.find(id);
            return View(bl);
        }

        // POST: web_admin/Blog/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(string id , FormCollection collection)
        {
            try
            {
                blogsData.Update(id, collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: web_admin/Blog/Delete/5
        public ActionResult Delete(string id)
        {

            Models.Blog bl = blogsData.find(id);
            return View(bl);
        }

        // POST: web_admin/Blog/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            
            blogsData.remove(collection["ID"]);
            TempData["Msg"] = "Xóa thành công";
            return RedirectToAction("Index");
            
        }
    }
}
