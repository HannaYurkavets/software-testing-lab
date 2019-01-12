using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace FrameworkStep2.Pages
{
    class Result
    {
        [FindsBy(How = How.Name, Using = "city_from")]
        public IWebElement From { get; set; }

        [FindsBy(How = How.Name, Using = "city_to")]
        public IWebElement To { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='baggage']")]
        public IWebElement BaggageIsEnabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='changeability']")]
        public IWebElement ExchangeIsPossible { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[5]/div[1]/div[1]/div[2]/div[1]/ul/li[1]/label/div/div[1]/span[1]")]
        public IWebElement ReturnIsPossible { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[5]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div[2]")]
        public IWebElement DirectFlights { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[5]/div[1]/div[1]/div[2]/div[3]/div/div[4]/ul/li[1]/label/input")]
        public IWebElement BeforeSixAM { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[5]/div[1]/div[1]/div[2]/div[3]/div/div[4]/ul/li[2]/label/input")]
        public IWebElement FromSixAMToTwelvePM { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[5]/div[1]/div[1]/div[2]/div[3]/div/div[4]/ul/li[3]/label/input")]
        public IWebElement FromTwelvePMToSixPM { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[5]/div[1]/div[2]/div[4]/div[9]/div/div[1]/div[8]/div[2]/div[1]/div")]
        public IWebElement ButtonOrder { get; set; }

        private IWebDriver webDriver { get; set; }

        public Result(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(webDriver, this);
        }
    }
}
