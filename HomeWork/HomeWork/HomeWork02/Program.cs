using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {

            Exercise01();

            Exercise02();

        }

        static void Exercise01()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://www.google.com.au";

            String Title = driver.Title;

            Console.WriteLine("Title of the page is : " + Title);

            String PageSource = driver.PageSource;

            int PageSourceLength = driver.PageSource.Length;

            Console.WriteLine("Page Source of the page is : " + PageSource);

            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

            driver.Quit();

        }

        static void Exercise02()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "https://www.facebook.com";

            IWebElement webElement = driver.FindElement(By.Id("email"));

            webElement.SendKeys("test123");
            webElement.Clear();
        }
    }
}
