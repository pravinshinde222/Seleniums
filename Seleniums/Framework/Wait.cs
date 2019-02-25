using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Seleniums.Framework
{
    public class Wait
    {
        public bool WaitForElement(IWebDriver driver,IWebElement element,string attributeName,string attributeValue)
        {
            Func<IWebDriver,bool> waitForElementToPresent=new Func<IWebDriver, bool>((IWebDriver web) =>
            { 
                if (element.GetAttribute(attributeName).Contains(attributeValue))
                {
                    return true;
                }
                return false;
            });
            return false;
        }



        public IWebElement waitForPageUntilElementIsVisible(IWebDriver driver,string cssPath)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                ExpectedConditions.ElementExists(By.CssSelector(cssPath)));
        }

    }
}
