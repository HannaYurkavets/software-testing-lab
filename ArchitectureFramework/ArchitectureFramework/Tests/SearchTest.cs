using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ArchitectureFramework.Tests
{
    [TestFixture]
    class SearchTest
    {
        private Steps.Steps steps = new Steps.Steps();
        private string departureFrom = "Минск (Белоруссия)";
        private string departureTo = "Лондон (Великобритания)";
        private string dateDepartureFrom = "20.11.2018";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void Search()
        {
            steps.SearchTickets(departureFrom,departureTo,dateDepartureFrom);
        }

    }
}
