using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStep2.Driver;
using FrameworkStep2.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace FrameworkStep2.Steps
{
    class Steps
    {
        public IWebDriver webDriver;

        private Main mainPage;

        private Result resultPage;

        public void InitBrowser()
        {
            webDriver = Driver.Driver.GetInstance();
        }

        public void CloseBrowser()
        {
            webDriver = null;
            Driver.Driver.CloseBrowser();
        }

        public void OpenMainPage()
        {
            mainPage = new Main(webDriver);

            mainPage.OpenPage();
        }

        public IWebElement SelectFromCity()
        {
            return mainPage.InputFromCity;
        }

        public IWebElement SelectToCity()
        {
            return mainPage.InputToCity;
        }


        public IWebElement SelectDepartDate()
        {
            return mainPage.DepartureDate;
        }

        public IWebElement SelectReturnDate()
        {
            return mainPage.ReturnDate;
        }

        public string GetDepartureDateValue()
        {
            var departureDate = mainPage.DepartureDate;
            return Convert.ToString(departureDate.GetAttribute("value"));
        }

        public string GetReturnDateValue()
        {
            var returnDate = mainPage.ReturnDate;
            return Convert.ToString(returnDate.GetAttribute("value"));
        }

        public IWebElement GetButtonOrder()
        {
            return resultPage.ButtonOrder;
        }
        public string GetErrorMessage()
        {
            var errorMessage = mainPage.ErrorMessage;
            return Convert.ToString(errorMessage.Text);
        }

        public string GetAdultValue()
        {
            var adultValue = mainPage.AdultValue;
            return Convert.ToString(adultValue.Text);
        }
        public string GetChildValue()
        {
            var childValue = mainPage.ChildValue;
            return Convert.ToString(childValue.Text);
        }
        public string GetBabyValue()
        {
            var babyValue = mainPage.BabyValue;
            return Convert.ToString(babyValue.Text);
        }

        public void IncreaseAdult()
        {
            mainPage.IncreaseAdult.Click();
        }

        public void IncreaseChild()
        {
            mainPage.IncreaseChild.Click();
        }

        public void IncreaseBaby()
        {
            mainPage.IncreaseBaby.Click();
        }

        public void FindResults()
        {
            mainPage.Find.Click();
        }

        public void OpenResultPage()
        {
            resultPage = new Result(webDriver);
        }

        public string GetFromCity()
        {
            var fromCity = resultPage.From;
            return Convert.ToString(fromCity.GetAttribute("value"));
        }

        public string GetToCity()
        {
            var toCity = resultPage.To;
            return Convert.ToString(toCity.GetAttribute("value"));
        }

        public void ApplyBaggageIsEnabled()
        {
            resultPage.BaggageIsEnabled.Click();
        }

        public void ApplyExchangeIsPossible()
        {

            resultPage.ExchangeIsPossible.Click();
        }

        public void ApplyReturnIsPossible()
        {
            resultPage.ReturnIsPossible.Click();
        }

        public void ApplyBeforeSixAM()
        {
            resultPage.BeforeSixAM.Click();
        }

        public void ApplyFromSixAMToTwelvePM()
        {
            resultPage.FromSixAMToTwelvePM.Click();
        }

        public void ApplyFromTwelvePMToSixPM()
        {
            resultPage.FromTwelvePMToSixPM.Click();
        }

        public void DirectFlights()
        {
            resultPage.DirectFlights.Click();
        }
    }
}
