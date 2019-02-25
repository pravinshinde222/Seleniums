using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Seleniums.Framework.Common;

namespace Seleniums.PageObjects
{
    public class BagPage: Base
    {   
        public BagPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "p[class='bag-item-name'] a")]
        private IWebElement productNameFromBag;


        public string GetProductNameFromBag(IWebDriver driver)
        {
            Thread.Sleep(2000);
            return productNameFromBag.Text;
        }
    }
}
