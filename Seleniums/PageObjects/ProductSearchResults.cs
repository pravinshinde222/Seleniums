using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Seleniums.Framework;
using Seleniums.Framework.Common;

namespace Seleniums.PageObjects
{
    public class ProductSearchResults:Base
    {   
        private ProductPage productPage;
        public static string productName = string.Empty;
        
        [FindsBy(How = How.ClassName, Using = "_1bD_SDN")]
        private readonly IWebElement sort;

        [FindsBy(How = How.ClassName, Using = "2o2AwBi")]
        private readonly IWebElement sortProducts;

        [FindsBy(How = How.CssSelector, Using = "div[class='_3-pEc3l'] section article a div img")]
        private readonly IWebElement randomProduct;

        [FindsBy(How = How.CssSelector, Using = "div[class='_3-pEc3l'] section article a div:nth-of-type(2) div div p")]
        private readonly IWebElement product;


        public ProductSearchResults(IWebDriver driver)
        {
            this.driver = driver;
            wait=new Wait();
            PageFactory.InitElements(driver,this);
        }

        public IWebDriver SortProductBasedOn_PriceLowToHigh()
        {
            sort.Click();
            var sortTypes = this.driver.FindElements(By.XPath("//ul[@data-test-id='sortOptions']/li"));

            foreach (var sortType in sortTypes)
            {
                string sortValue=sortType.FindElement(By.TagName("a")).Text;
                if (sortValue.Contains("Price low to high"))
                {
                    sortType.FindElement(By.CssSelector("a[class*='gF'] span")).Click();
                    break;
                }
            }
           
            return this.driver;
        }

        public ProductPage SelectAnyRandomProduct()
        {
           IWebElement ELE= wait.waitForPageUntilElementIsVisible(driver, "div[class='_3-pEc3l'] section article a div img");

            Thread.Sleep(4000);
            productName = product.Text;
            randomProduct.Click();
           
           return new ProductPage(this.driver);
        }

        public List<string> GetListOfCheapTshirts(IWebDriver driver)
        {
            var productList = new List<string>();
            int count = 0;
            string productName = null;
            var products=driver.FindElements(By.XPath("//div[@class='_3-pEc3l']/section/article"));
            foreach (var product in products)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                       productName = product.FindElement(By.XPath("a[@class='_3x-5VWa']/div[2]/div/div/p")).Text;
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine(e.StackTrace);
                    }
                }
                
                productList.Add(productName);
                count++;
                if(count>10)
                    break;
            }

            return productList;
        }
    }
}
