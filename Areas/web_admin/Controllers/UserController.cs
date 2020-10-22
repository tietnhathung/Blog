using Blog.Areas.web_admin.Data;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: web_admin/User
        public ActionResult Index()
        {
            UserData  dtus = new UserData();
            List<Models.User> listUser = dtus.all();
            return View(listUser);
        }

        // GET: web_admin/User/Details/5
        public ActionResult Details(string id)
        {
            UserData dtus = new UserData();
            Models.User user = dtus.find(id);
            return View(user);
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

                    TempData["Msg"] = "Tạo người dung " + u.full_name + "thành công!";

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

       
        [HttpGet]
        public ActionResult ChangePass(string id)
        {
            UserData dtus = new UserData();
            Models.User user = dtus.find(id);
            return View(user);
        }
       
        [HttpPost]
        public ActionResult ChangePass(Models.User user)
        {

            UserData dataU = new UserData();
            User newUser = dataU.ChangePass(user);

            TempData["Msg"] = "Cập nhật người dung" + user.full_name + " thành công!";

            return RedirectToAction("Details");
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
        public ActionResult Edit( Models.User user)
        {

            UserData dataU = new UserData();
            User newUser = dataU.Update(user);

            var section = (UserSection)Session[Constants.USER_SECTION];
            if (section.UserID == newUser.ID)
            {
                UserSection us = new UserSection(newUser);
                Session.Add(Constants.USER_SECTION, us);
            }

            TempData["Msg"] = "Cập nhật người dung" + user.full_name + " thành công!";

            return RedirectToAction("Index");
        }

        // GET: web_admin/User/Delete/5
        public ActionResult Delete(string id)
        {
            UserData dtus = new UserData();
            Models.User listUser = dtus.find(id);
            return View(listUser);
        }

        // POST: web_admin/User/Delete/5
        [HttpPost]
        public ActionResult Delete( FormCollection collection)
        {
            try
            {

                UserData dataU = new UserData();
                dataU.remove(collection["ID"]);
                TempData["Msg"] = "Cập nhật người dung thành công!";
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
    }
}
