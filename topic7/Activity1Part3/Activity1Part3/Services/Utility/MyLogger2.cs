﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Utility
{
    public class MyLogger2 : ILogger
    {

        // singleton pattern example. Only one instance of this class can be Instanciated
        private Logger logger; // static variable to hold a single instance of the nLog logger



        private Logger GetLogger(string theLogger)
        {
            if (logger == null)
                logger = LogManager.GetLogger(theLogger);

            return logger;

        }


        public void Debug(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("myAppLoggerRules").Debug(message);
            else
                GetLogger("myAppLoggerRules").Debug(message, arg);
        }

        public void Error(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("myAppLoggerRules").Error(message);
            else
                GetLogger("myAppLoggerRules").Error(message, arg);
        }

        public void Info(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("myAppLoggerRules").Info(message);
            else
                GetLogger("myAppLoggerRules").Info(message, arg);
        }

        public void Warning(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("myAppLoggerRules").Warn(message);
            else
                GetLogger("myAppLoggerRules").Warn(message, arg);
        }
    }
}