using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace FrameworkStep2.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void StartBrowser()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void CityDidntExistTest()
        {
            var cityName = "q";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(cityName);
            steps.FindResults();
            var errorMessage = steps.GetErrorMessage();
            Assert.AreEqual(errorMessage, "Пожалуйста, укажите город вылета");
        }

        [Test]
        public void ToDateTest()
        {
            var fromCity = "Москва (Россия)";
            var toCity = "Дубай (ОАЭ)";
            var departDay = "30.12.2018";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);

            steps.SelectDepartDate().SendKeys(departDay);
            steps.SelectDepartDate().SendKeys(Keys.Enter);
            var departDate = steps.GetDepartureDateValue();
            var expectedDate = DateTime.Now.Day.ToString() +"."+ DateTime.Now.Month.ToString()+"." + DateTime.Now.Year.ToString();
            Assert.AreEqual(departDate, expectedDate);
        }

        [Test]
        public void FromDateMoreThanToDateTest()
        {
            var fromCity = "Москва (Россия)";
            var toCity = "Дубай (ОАЭ)";
            var departDay = "03.04.2019";
            var returnDay = "02.04.2019";
            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectDepartDate().SendKeys(departDay);
            steps.SelectReturnDate().SendKeys(returnDay);
            steps.SelectReturnDate().SendKeys(Keys.Enter);
            var returnDate = steps.GetReturnDateValue();
           
            Assert.AreEqual(returnDate, departDay);
        }

        [Test]
        public void IncreaseAdultTest()
        {
            steps.OpenMainPage();
            steps.IncreaseAdult();
            var adultValue = steps.GetAdultValue();

            Assert.AreEqual(adultValue, "2 взрослых");
        }

        [Test]
        public void IncreaseChildTest()
        {
            steps.OpenMainPage();
            steps.IncreaseChild();
            var childValue = steps.GetChildValue();

            Assert.AreEqual(childValue, "1 ребенок до 12 лет");
        }


        [Test]
        public void IncreaseBabyTest()
        {
            steps.OpenMainPage();
            steps.IncreaseBaby();
            var babyValue = steps.GetBabyValue();

            Assert.AreEqual(babyValue, "1 малыш до 2 лет");
        }

        [Test]
        public void ResultFlightsTest()
        {
            var fromCity = "Москва (Россия)";
            var toCity = "Дубай (ОАЭ)";
            var departDay = "03.04.2019";

            steps.OpenMainPage();
            steps.SelectFromCity().SendKeys(fromCity);
            steps.SelectToCity().SendKeys(toCity);
            steps.SelectDepartDate().SendKeys(departDay);
            steps.FindResults();
            steps.OpenResultPage();

            var fromCityResult = steps.GetFromCity();
            var toCityResult = steps.GetToCity();

            Assert.AreEqual(fromCity, fromCityResult);
        }

        [Test]
        public void ApplyBaggageIsEnabledTest()
        {
            ResultFlightsTest();

            steps.ApplyBaggageIsEnabled();
            Assert.IsTrue(steps.GetButtonOrder().Displayed);
        }

        [Test]
        public void ApplyExchangeIsPossibleTest()
        {
            ResultFlightsTest();

            steps.ApplyExchangeIsPossible();
            Assert.IsTrue(steps.GetButtonOrder().Displayed);
        }

        [Test]
        public void ApplyReturnIsPossibleTest()
        {
            ResultFlightsTest();
            steps.ApplyReturnIsPossible();
            Assert.IsTrue(steps.GetButtonOrder().Displayed);
        }

        [Test]
        public void ApplyBeforeSixAMTest()
        {
            ResultFlightsTest();
            steps.ApplyBeforeSixAM();
            Assert.IsTrue(steps.GetButtonOrder().Displayed);
        }

        [Test]
        public void ApplyFromSixAMToTwelvePMTest()
        {
            ResultFlightsTest();
            steps.ApplyFromSixAMToTwelvePM();
            Assert.IsTrue(steps.GetButtonOrder().Displayed);
        }

        [Test]
        public void ApplyFromTwelvePMToSixPMTest()
        {
            ResultFlightsTest();
            steps.ApplyFromTwelvePMToSixPM();
            Assert.IsTrue(steps.GetButtonOrder().Displayed);
        }

        [Test]
        public void DirectFlightsTest()
        {
            ResultFlightsTest();
            steps.DirectFlights();
            Assert.IsTrue(steps.GetButtonOrder().Displayed);
        }

        static void Main(string[] args) { }
    }
}
