using Blog.Areas.web_admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Controllers
{
    public class UserController : Controller
    {
        // GET: web_admin/User
        public ActionResult Index()
        {
            UserData  dtus = new UserData();
            List<Models.User> listUser = dtus.all();
            return View(listUser);
        }

        // GET: web_admin/User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: web_admin/User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: web_admin/User/Create
        [HttpPost]
        public ActionResult Create(Models.User u)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    UserData us = new UserData();

                    u.ID = Guid.NewGuid().ToString();
                    u.create_at = DateTime.Now;
                    us.Insert(u);

                    TempData["Msg"] = "Tạo user " + u.full_name + "thành công!";

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: web_admin/User/Edit/5
        public ActionResult Edit(string id)
        {
            UserData dtus = new UserData();
            Models.User listUser = dtus.find(id);
            return View(listUser);
        }

        // POST: web_admin/User/Edit/5
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

        // GET: web_admin/User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: web_admin/User/Delete/5
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
