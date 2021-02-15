using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class CustomAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            SecurityService securityService = new SecurityService();

            // get a user from the session variable
            UserModel user = (UserModel)filterContext.HttpContext.Session["user"];

            bool success = false;

            if(user != null)
            {
                success = securityService.Authenticate(user);
            }
                if (success)
                {
                    // do nothing. logged in successfully. let the controller event continue as normal.
                }
                else
                {
                    // no user is logged in, redirect to the login page
                    filterContext.Result = new RedirectResult("/login");
                }
        }
    }
}