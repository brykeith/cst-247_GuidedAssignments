using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService2Controller : Controller
    {

        public ILogger logger { get; set; }

        public TestLoggingService2Controller(ILogger logger)
        {
            this.logger = logger;
        }



        // GET: TestLoggingService2
        public string Index()
        {
            logger.Info("testing logger.info within index method of TestLogginService2Controller.cs");
            return "testing logger.info within index method of TestLogginService2Controller.cs";
        }
    }
}