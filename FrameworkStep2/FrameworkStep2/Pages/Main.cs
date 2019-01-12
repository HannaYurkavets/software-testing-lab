using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrameworkStep2.Pages
{
    class Main
    {
        private const string BASE_URL = "https://avia.tutu.ru/";

        [FindsBy(How = How.Name, Using = "date_from")]
        public IWebElement DepartureDate { get; set; }

        [FindsBy(How = How.Name, Using = "date_back")]
        public IWebElement ReturnDate { get; set; }

        [FindsBy(How = How.Name, Using = "city_from")]
        public IWebElement InputFromCity { get; set; }

        [FindsBy(How = How.Name, Using = "city_to")]
        public IWebElement InputToCity { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[7]/div/div[1]/div[1]/div/div[2]")]
        public IWebElement IncreaseAdult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[7]/div/div[1]/div[1]/div/div[3]")]
        public IWebElement AdultValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[7]/div/div[1]/div[2]/div/div[2]")]
        public IWebElement IncreaseChild { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[7]/div/div[1]/div[2]/div/div[3]")]
        public IWebElement ChildValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[7]/div/div[1]/div[3]/div/div[2]")]
        public IWebElement IncreaseBaby { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[7]/div/div[1]/div[3]/div/div[3]")]
        public IWebElement BabyValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[2]/div[7]/button/span/span[3]")]
        public IWebElement Find { get; set; }

        [FindsBy(How = How.Id, Using = "qtip-0-content")]
        public IWebElement ErrorMessage { get; set; }

        private IWebDriver webDriver;

        public Main(IWebDriver driver)
        {
            webDriver = driver;

            PageFactory.InitElements(webDriver, this);
        }

        public void OpenPage()
        {
            webDriver.Navigate().GoToUrl(BASE_URL);
        }

    }
}
