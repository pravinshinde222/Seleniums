using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Seleniums.Framework.Common;

namespace Seleniums.PageObjects
{
    public class SearchPage:Base
    {
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.Id, Using = "chrome-search")]
        private readonly IWebElement searchProduct;

        [FindsBy(How = How.Id, Using = "chrome-search")]
        private readonly IWebElement menCategory;

        [FindsBy(How = How.Id, Using = "chrome-search")]
        private readonly IWebElement Shes;

        [FindsBy(How = How.CssSelector, Using = "button[aria-label='My Account']")]
        private IWebElement AccountIcon;

        [FindsBy(How = How.ClassName, Using = "_1k1reGo")]
        private IWebElement signInLink;


        public ProductSearchResults SearchForProduct(string productType)
         {
            menCategory.Click();
            searchProduct.SendKeys(productType);
            var searchResult=this.driver.FindElements(By.XPath("//div[@class='_2m6gPa2']/ul/li"));
            searchResult.FirstOrDefault().FindElement(By.XPath("//button[@class='_1kpn9KI']/span")).Click();
            return new ProductSearchResults(driver);
         }

        public SignInPage GotoSignInPage()
        {
            _helper.MoveToElementUsingActions(this.driver, AccountIcon);
            signInLink.Click();
            return new SignInPage(this.driver);
        }
    }
}
