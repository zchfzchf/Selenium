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
        public static HomePage LoginPage
        {
            get
            {
                var loginPage = new HomePage();
                return loginPage;
            }
        }
        public static HomePage ListPage
        {
            get
            {
                var listPage = new HomePage();
                return listPage;
            }
        }
    }
}
