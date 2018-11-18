using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ArchitectureFramework.Pages
{
    class InitialPage
    {
        private const string url = "https://avia.tutu.ru/";

        private IWebDriver driver;

        public InitialPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[3]/div/div[2]/div[1]/div[1]/input")]
        private IWebElement from;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[3]/div/div[2]/div[3]/div[1]/input")]
        public IWebElement to;

        [FindsBy(How = How.Name, Using = "date_from")]
        public IWebElement dateFrom;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[3]/div/div[2]/div[7]/button/span/span[3]")]
        public IWebElement buttonSearch;

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("Initial page opened");
        }

        public void Search(string departureFrom, string departureTo, string dateDepartureFrom)
        {
            from.SendKeys(departureFrom);
            to.SendKeys(departureTo);
            dateFrom.SendKeys(dateDepartureFrom);
            buttonSearch.Click();
        }
    }
}
