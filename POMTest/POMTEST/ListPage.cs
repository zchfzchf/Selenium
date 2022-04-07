using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;

namespace POMTEST
{
    public class ListPage
    {
        public void SelectProducts()
        {
            WebDriverWait wait = new WebDriverWait(Browser.webDriver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("产品介绍")));

            IWebElement products = Browser.webDriver.FindElement(By.LinkText("产品介绍"));
            products.Click();
        }
    }
}
