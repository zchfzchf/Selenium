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
    public class HomePage
    {
        static String Url = "http://lyratesting2.co.nz/";

        Browser br = new Browser();

        //[FindsBy(How=How.LinkText, using="登录")]
        //private IWebElement Login;

        
        //[FindsBy(How=How.XPath, Using="/html/body/div[1]/section[2]/div/div[4]/a"];
        //private IWebElement loadMore;

        // To Login

        public void SelectLogin()
        {
            WebDriverWait wait = new WebDriverWait(br.Br(), new TimeSpan(0, 0, 5));

            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("登录")));
            IWebElement Login = br.Br().FindElement(By.LinkText("登录"));
            Login.Click();
        }

        public void SelectLoadMore()
        {
            WebDriverWait wait = new WebDriverWait(br.Br(), new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/section[2]/div/div[4]/a")));
            IWebElement  LoadMore= br.Br().FindElement(By.XPath("/html/body/div[1]/section[2]/div/div[4]/a"));
            LoadMore.Click();
        }

        public void Goto()
        {
            br.Goto(Url);
        }
    }
}
