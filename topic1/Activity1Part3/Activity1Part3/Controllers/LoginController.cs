﻿using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            SecurityService securityService = new SecurityService();
            bool result = securityService.Authenticate(model);

            if (result == true)
                return View("LoginPassed");
            else
                return View("LoginFailed");
            
            
        }
    }
}