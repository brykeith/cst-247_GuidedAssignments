using Activity1Part3.Services.Utility;
using System;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    internal class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            MyLogger.GetInstance().Info("Controller name: " + filterContext.RouteData.Values["controller"].ToString() + " Action name: " + filterContext.RouteData.Values["action"].ToString());
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            MyLogger.GetInstance().Info("Controller name: " + filterContext.RouteData.Values["controller"].ToString() + " Action name: " + filterContext.RouteData.Values["action"].ToString());
        }
    }
}