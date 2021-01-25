using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {

        public static List<ButtonModel> buttons = new List<ButtonModel>
        {
            new ButtonModel(state: true),
            new ButtonModel(state: false)
        };

        // GET: Button
        public ActionResult Index()
        {
            return View("Button", buttons);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if (mine.Equals("1"))
            {
                buttons[0].State = !buttons[0].State;
            }
            if (mine.Equals("2"))
            {
                buttons[1].State = !buttons[1].State;
            }
            return View("Button", buttons);
        }
    }
}