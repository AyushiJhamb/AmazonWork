using System;
using System.Collections.Generic;
using System.Configuration;

namespace AmazonWork
{
  public static class Constants
    {
        public static string WebDriverPath = ConfigurationManager.AppSettings["WebdriverPath"];
        public static string AppUrl = ConfigurationManager.AppSettings["Url"];
        public static string AppName = "JavaTPoint: Web Application";
    }
}
