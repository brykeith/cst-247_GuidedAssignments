﻿using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService3Controller : Controller
    {

        private ILogger logger;
        private ITestService service;

        public TestLoggingService3Controller(ILogger logger, ITestService service)
        {
            this.logger = logger;
            this.service = service;
        }



        // GET: TestLoggingService3
        public string Index()
        {
            logger.Info("testing logger.info within index method of TestLoggingService3Controller.cs");
            service.TestLogger();
            return "testing logger.info within index method of TestLoggingService3Controller.cs";
        }
    }
}