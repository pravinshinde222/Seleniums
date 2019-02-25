using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Seleniums.Framework
{
   public class Helper
   {   
        public void ReturnFromDropDown(IWebElement dropDownWebElement,int index)
        {
            SelectElement selectValue=new SelectElement(dropDownWebElement);
            selectValue.SelectByIndex(index);
        }

        public IWebDriver MoveToElementUsingActions(IWebDriver driver,IWebElement element)
        {
            var action=new Actions(driver);
            action.MoveToElement(element).Perform();
            return driver;
        }
    }
}
