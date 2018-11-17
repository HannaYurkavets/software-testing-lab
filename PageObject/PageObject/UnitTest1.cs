using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObject
{
    [TestClass]
    public class AviaTutuSearch
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://avia.tutu.ru/";

        public AviaTutuSearch(IWebDriver browser)
        {
            this.driver = browser;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(browser, this);
        }
        [TestMethod]
        public bool SearchAndClickElement()
        {
            bool actual = false;
            try
            {
                driver.Navigate().GoToUrl(url);

                driver.FindElement(By.XPath(@"/html/body/div[1]/div/div[3]/div/div[2]/div[1]/div[1]/input")).SendKeys("Минск (Белоруссия)");

                driver.FindElement(By.XPath(@"/html/body/div[1]/div/div[3]/div/div[2]/div[3]/div[1]/input")).SendKeys("Лондон (Великобритания)");

                driver.FindElement(By.Name(@"date_from")).SendKeys("28.10.2018");

                driver.FindElement(By.XPath(@"/html/body/div[1]/div/div[3]/div/div[2]/div[7]/button/span/span[3]")).Click();

            }
            catch (Exception)
            {
                actual = true;
            }
            return actual;
        }
        public void ValidateResults(bool actual)
        {
            Assert.IsTrue(actual);
        }
    }
}
