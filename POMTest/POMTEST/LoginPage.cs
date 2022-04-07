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
    public class LoginPage
    {
        public void Login(string name, string password)
        {
            WebDriverWait wait = new WebDriverWait(Browser.webDriver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("js-btn-login")));

            IWebElement userName = Browser.webDriver.FindElement(By.Id("login_username"));
            userName.Click();
            userName.SendKeys(name);

            IWebElement pwd=Browser.webDriver.FindElement(By.Id("login_password"));
            pwd.SendKeys(password);

            IWebElement loginBtn=Browser.webDriver.FindElement(By.ClassName("js-btn-login"));
            loginBtn.Click();
        }
    }
}
