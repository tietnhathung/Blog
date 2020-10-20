using Blog.Areas.web_admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog.Areas.web_admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            var section = (UserSection)Session[Constants.USER_SECTION];
            if (section == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "login", action = "login", Area = "web_admin" }));
            }
            base.OnActionExecuted(filterContext);
        }
    }
}