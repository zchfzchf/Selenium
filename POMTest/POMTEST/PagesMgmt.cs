using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTEST
{
    public class PagesMgmt
    {
        public static HomePage Homepage
        {
            get
            {
                var homePage = new HomePage();
                return homePage;
            }
        }
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                return loginPage;
            }
        }
        public static ListPage ListPage
        {
            get
            {
                var listPage = new ListPage();
                return listPage;
            }
        }
    }
}
