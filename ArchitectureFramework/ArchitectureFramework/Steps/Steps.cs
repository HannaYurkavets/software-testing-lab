using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ArchitectureFramework.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SearchTickets(string departureFrom, string departureTo, string dateDepartureFrom)
        {
            Pages.InitialPage initialPage = new Pages.InitialPage(driver);
            initialPage.OpenPage();
            initialPage.Search(departureFrom, departureTo, dateDepartureFrom);
        }
    }        
}
