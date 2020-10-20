using Blog.Areas.web_admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.User dataLogin)
        {
            if (ModelState.IsValid)
            {
                UserData user = new UserData();
                var res = user.login(dataLogin.username, dataLogin.password);
                if (res)
                {
                    Models.User userLogin = user.GetByUserName(dataLogin.username);
                    UserSection us = new UserSection(userLogin);
                    Session.Add(Constants.USER_SECTION, us);
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else
                {
                    ModelState.AddModelError("login", "Đăng nhập thất bại");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("login", "Đăng nhập thất bại");
                return View();
            }
        }
        [HttpPost]
        public ActionResult logout()
        {
            Session.Add(Constants.USER_SECTION, null);
            return RedirectToAction("login", "login");
        }
    }
}