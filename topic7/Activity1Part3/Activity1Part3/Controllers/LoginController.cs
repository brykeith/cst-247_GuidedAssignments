using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utility;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {


        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [CustomAction]
        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            
            // put an item in the log
            MyLogger.GetInstance().Info("Entering the login Controller. Login Method");


            try
            {

                // Validate the Form POST
                if (!ModelState.IsValid)
                    return View("Login");

                SecurityService securityService = new SecurityService();
                bool success = securityService.Authenticate(model);

                if (success)
                {
                    Session["user"] = model;
                    MyLogger.GetInstance().Info("Exit login Controller. Login Success!");
                    return View("LoginPassed");
                }
                else
                {
                    Session.Clear();
                    MyLogger.GetInstance().Info("Exit login Controller. Login Failed!");
                    return View("LoginFailed");
                }


            }
            catch (Exception e)
            {
                MyLogger.GetInstance().Error("Exception in Login: " + e.Message);
                return Content("Exception in Login" + e.Message);

            }


        }

        [CustomAuthorization]
        public ActionResult OnProtectedURL()
        {
            return Content("Private info");
        }

        

        
        
    }
}