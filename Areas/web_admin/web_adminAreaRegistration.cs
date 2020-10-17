using System.Web.Mvc;

namespace Blog.Areas.web_admin
{
    public class web_adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "web_admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "web_admin_default",
                "web_admin/{controller}/{action}/{id}",
                new { controller= "HomeAdmin", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
