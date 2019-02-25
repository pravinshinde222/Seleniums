using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions.Common;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;

namespace Seleniums.Tests
{
    [TestFixture()]
    public class SetUpLogic
    {
        public IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.FullScreen();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseurl"]);
        }

        [TearDown]
        public void Closure()
        {
            driver.Quit();
        }

    }
}
