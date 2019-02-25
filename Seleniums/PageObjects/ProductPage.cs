using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Seleniums.Framework;
using Seleniums.Framework.Common;

namespace Seleniums.PageObjects
{
    public class ProductPage:Base
    { 
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
      
        }

        [FindsBy(How = How.XPath, Using = "//select[@data-id='sizeSelect']")]
        private IWebElement sizeWebElement;

        [FindsBy(How = How.XPath, Using = "//a[@class='add-button']/span[2]")]
        private IWebElement addToBagButton;

        [FindsBy(How = How.CssSelector, Using = "div[id='miniBagDropdown'] a")]
        private IWebElement miniBagDropDown;

        [FindsBy(How = How.CssSelector, Using = "div[id=\'minibag-dropdown\'] div div div:nth-of-type(3) div div.OWGtwg_ div a span")]
        private IWebElement viewBag;

   

        [FindsBy(How = How.CssSelector, Using = "a[class='add-button'] span:nth-of-type(2)")]
        private IWebElement addToBagLink;

        public BagPage AddtoBagProduct()
        {
            SelectElement selectValue = new SelectElement(sizeWebElement);
            selectValue.SelectByIndex(2);
           addToBagLink.Click();
           this.driver = this._helper.MoveToElementUsingActions(this.driver,miniBagDropDown);
            Thread.Sleep(4000);
           viewBag.Click();
           return new BagPage(driver);
        }



    }
}
