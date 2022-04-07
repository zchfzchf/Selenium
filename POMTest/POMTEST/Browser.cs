using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTEST
{
    public class Browser
    {
        private IWebDriver webDriver = new FirefoxDriver();

        public IWebDriver Br()
        {
            return webDriver;
        }

        public void Goto(string url)
        {
            webDriver.Url = url;
        }

        public void Close()
        {
            webDriver.Quit();
        }


        /* Original
        static IWebDriver webDriver = new FirefoxDriver();

        public static String Title
        {
            get { return webDriver.Title; }
        }

        
        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver Driver2
        {
            get { return webDriver; }
        }
        
        
        public static IWebDriver webDriver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
        */
    }
}
