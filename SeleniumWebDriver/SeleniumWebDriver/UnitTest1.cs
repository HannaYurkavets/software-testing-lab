using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver chrome = new ChromeDriver(@"D:\UCH\4course\1sem\QA\lab1\ConsoleApp1\software-testing-lab\SeleniumWebDriver\SeleniumWebDriver\bin\Debug");

        [TestMethod]
        public void TestMethod1()
        {

            chrome.Navigate().GoToUrl("https://avia.tutu.ru/");

            chrome.FindElement(By.XPath(@"/html/body/div[1]/div/div[3]/div/div[2]/div[1]/div[1]/input")).SendKeys("Минск (Белоруссия)");

            chrome.FindElement(By.XPath(@"/html/body/div[1]/div/div[3]/div/div[2]/div[3]/div[1]/input")).SendKeys("Лондон (Великобритания)");

            chrome.FindElement(By.Name(@"date_from")).SendKeys("18.11.2018");

            chrome.FindElement(By.XPath(@"/html/body/div[1]/div/div[3]/div/div[2]/div[7]/button/span/span[3]")).Click();


            bool actual = false;
            Thread.Sleep(500);
            try
            {

                chrome.FindElement(By.XPath("/html/body/div[2]/div[6]/div[1]/div[2]/div[4]/div[9]"));

            }
            catch (Exception)
            {
                actual = true;
            }

            Assert.AreEqual(true, actual);

        }
        [TestCleanup]
        public void TearDown()
        {
            chrome.Quit();
        }
    }
}
