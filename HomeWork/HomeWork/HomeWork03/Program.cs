using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace HomeWork03
{/// <summary>
/// Different methods to select the Elements; <select> Tag
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Methods();

            Radio_ChkBox();

            SelectOption();
        }

        static void Methods()
        {

            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://106.15.238.71/testpage1.html";

            // By.Id

            IWebElement elementById = driver.FindElement(By.Id("submit"));
            elementById.Submit();

            // By.ClassName
            IList<IWebElement> elementByClass = driver.FindElements(By.ClassName("control-group"));
            Console.WriteLine(elementByClass.Count);

            // By.Name
            IWebElement elementByName = driver.FindElement(By.Name("submit"));
            elementByName.Submit();

            // By.LinkText
            IWebElement elementByLinkText = driver.FindElement(By.LinkText("Partial Link Test"));
            elementByLinkText.Click();
            driver.Navigate().Back();

            // By.PartialLinkText
            IWebElement elementByPartialLinkText = driver.FindElement(By.PartialLinkText("Partial Link"));
            elementByPartialLinkText.Click();
            driver.Navigate().Back();

            // By.XPath
            IWebElement elementByXPath = driver.FindElement(By.XPath("/html/body/form/fieldset/div[1]/input[1]"));
            elementByXPath.SendKeys("Lyra Education");
            Thread.Sleep(2000);
            elementByXPath.Clear();

            // By.CssSlector

            IWebElement elementByCssSelector = driver.FindElement(By.CssSelector("input[name='firstname']"));
            elementByCssSelector.SendKeys("Lyra Education");
            Thread.Sleep(2000);
            elementByCssSelector.Clear();

            driver.Quit();

        }

        static void Radio_ChkBox()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://106.15.238.71/testpage1.html");

            IList<IWebElement> rdBtn_sex = driver.FindElements(By.Name("sex"));

            foreach (var iRd in rdBtn_sex)
            {
                Console.WriteLine(iRd.GetAttribute("value"));
            }

            Boolean bValue = rdBtn_sex.ElementAt(0).Selected;

            Console.WriteLine("This is bValue {0}", bValue);

            Console.WriteLine(bValue);

            if (bValue == false)
            {
                rdBtn_sex.ElementAt(0).Click();
            }
            else
            {
                rdBtn_sex.ElementAt(1).Click();
            }

            IWebElement rdBtn_Exp = driver.FindElement(By.Id("exp-2"));
            rdBtn_Exp.Click();

            IList<IWebElement> chkBx_Profession = driver.FindElements(By.Name("profession"));

            int iSize = chkBx_Profession.Count;

            for (int i = 0; i < iSize; i++)
            {
                String chkValue = chkBx_Profession.ElementAt(i).GetAttribute("value");
                if (chkValue.Equals("Automation Tester"))
                {
                    chkBx_Profession.ElementAt(i).Click();
                    break;
                }
            }

            IWebElement ocheckBox = driver.FindElement(By.CssSelector("input[value='Selenium IDE']"));
            ocheckBox.Click();


            IList<IWebElement> chkBx_Tool = driver.FindElements(By.Name("tool"));
            int tSize = chkBx_Tool.Count;
            for (int i = 0; i < tSize; i++)
            {
                String chkValue = chkBx_Tool.ElementAt(i).GetAttribute("value");
                if (chkValue == "QTP")
                {
                    chkBx_Tool.ElementAt(i).Click();
                    break;

                }
            }

            driver.Close();
        }

        static void SelectOption()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://106.15.238.71/testpage1.html";

            SelectElement oSelection = new SelectElement(driver.FindElement(By.CssSelector("#continents.input-xlarge[name='continents']")));

            oSelection.SelectByText("Europe");
            Thread.Sleep(2000);

            oSelection.SelectByIndex(2);
            Thread.Sleep(2000);

            IList<IWebElement> oSize = oSelection.Options;
            int iListSize = oSize.Count;
            for (int i = 0; i < iListSize; i++)
            {
                String sValue = oSelection.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the select item is: " + sValue);
                if (sValue.Equals("Africa"))
                {
                    oSelection.SelectByIndex(i);
                }

            }

            SelectElement oSelenium = new SelectElement(driver.FindElement(By.XPath("//*[@id='selenium_commands'][@name='selenium_commands']")));
            oSelenium.SelectByIndex(0);
            Thread.Sleep(2000);
            oSelenium.DeselectByIndex(0);

            oSelenium.SelectByText("Navigation Commands");
            Thread.Sleep(2000);
            oSelenium.DeselectByText("Navigation Commands");
                       
            IList<IWebElement> oSeleniumOpts = oSelenium.Options;
            int oSeleniumSize = oSeleniumOpts.Count;
            for (int i = 0; i < oSeleniumSize; i++)
            {
                String oSeleniumValue = oSeleniumOpts.ElementAt(i).Text;
                Console.WriteLine("Value of the item is: " + oSeleniumValue);
                oSelenium.SelectByIndex(i);
                Thread.Sleep(2000);
            }

            oSelenium.DeselectAll();
            Thread.Sleep(2000);
                                 
            driver.Close();
        }
    }
}
