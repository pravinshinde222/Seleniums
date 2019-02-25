using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Seleniums.Tests
{
    [TestFixture()]
    class Practice:SetUpLogic
    {
        [Test]
        public void Exercise1()
        {
            var elements=driver.FindElements(By.Name("sex"));
            if (elements[0].Selected)
            {
                elements[1].Click();
            }
            else
            {
                elements[0].Click();
            }

            var yrsOfExperience=driver.FindElements(By.Name("exp"));
            yrsOfExperience[2].Click();

            var professions = driver.FindElements(By.Name("profession"));
            foreach (var profession in professions)
            {
                string text = profession.GetAttribute("value");
                if (text.Contains("Automation Tester"))
                {
                    profession.Click();
                    break;
                }
            }

            var tools= driver.FindElements(By.Name("tool"));
            foreach (var tool in tools)
            {
                string text = tool.GetAttribute("value");
                if (text.Contains("IDE"))
                {
                    tool.Click();
                    break;
                }
            }
            SelectElement select=new SelectElement(driver.FindElement(By.Id("continents")));
            select.SelectByIndex(2);

            Func<IWebDriver,bool> waitForElement=new Func<IWebDriver, bool>((IWebDriver web) =>
            {

            });

        }
    }
}
