using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ArchitectureFramework.Pages
{
    class Result
    {
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
