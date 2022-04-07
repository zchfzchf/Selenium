using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            POMTEST.HomePage homePage = new POMTEST.HomePage();
            homePage.Goto();
            homePage.SelectLogin();
            
        }
    }
}
