using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium
{
    [TestFixture]
    class Selenium
    {

        private const string url = "https://avia.tutu.ru/";

        [Test]
        static void Main(string[] args)
        {
            try
            { 
                IWebDriver chrome = new ChromeDriver();
                chrome.Url = url;
                chrome.FindElement(By.Name("city_from")).SendKeys("Минск (Белоруссия)");
                chrome.FindElement(By.Name("city_to")).SendKeys("Лондон(Великобритания)");
                chrome.FindElement(By.Name("date_from")).SendKeys("14.10.2018");
                chrome.FindElement(By.Name("date_back")).SendKeys("14.11.2018");
                chrome.FindElement(By.ClassName("b-button_block")).Click();
                ReadOnlyCollection<IWebElement> h5elements = chrome.FindElements(By.TagName("h5"));
                foreach (var h5 in h5elements)
                {
                    Assert.AreNotEqual(h5.Text.ToLower(), "Return".ToLower());
                }
            }
            catch (NoSuchElementException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
