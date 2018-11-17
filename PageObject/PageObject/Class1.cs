using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace PageObject
{
    [TestClass]
    class AviaTutuSearchFrom1
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver(@"D:\UCH\4course\1sem\QA\lab1\ConsoleApp1\software-testing-lab\WebDriver\selenium\bin\Debug");
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void SearchTicketWithoutAgreement()
        {
            AviaTutuSearch ticket = new AviaTutuSearch(this.Driver);
            ticket.ValidateResults(ticket.SearchAndClickElement());
        }
    }
}
