using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class DefaultController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            DataBaseBlog db = new DataBaseBlog();
            List<Models.Category> list = db.Categories.ToList();

            ViewBag.ListCate = list;

            base.OnActionExecuted(filterContext);
        }
    }
}