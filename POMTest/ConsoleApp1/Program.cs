using POMTEST;
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
            PagesMgmt.Homepage.Goto();
            PagesMgmt.Homepage.SelectLogin();
            PagesMgmt.LoginPage.Login("test001", "Test1234");
            PagesMgmt.Homepage.SelectLoadMore();
            PagesMgmt.ListPage.SelectProducts();
            
        }
    }
}
