using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [Route("test")]
        public ActionResult Index()
        {
            List<UserModel> UserModels = new List<UserModel>
            {
                new UserModel("Brad", "sports@football.com", "1234567890"),
                new UserModel ("Ryan", "fun@ball.com", "0987654321"),
                new UserModel ("Chelsey", "dog@cat.com", "1234567890")
            };

            return View("test", UserModels);
        }
    }
}