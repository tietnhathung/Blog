using Blog.Areas.web_admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.web_admin.Controllers
{
    public class HomeAdminController : BaseController
    {
        // GET: web_admin/Home
        public ActionResult Index()
        {
           
            return View();
        }

        

    }
}