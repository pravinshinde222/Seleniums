using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Seleniums.Framework
{
    public class ExceptionHandling
    {

        public IWebDriver HandleStaleReferenceException(IWebDriver driver,string xPath)
        {

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    driver.FindElement(By.XPath(xPath)).Click();
                    break;
                }
                catch (Exception e)
                {
                    
                }
            }

            return driver;
        }
    }
}
