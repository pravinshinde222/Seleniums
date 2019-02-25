using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Seleniums.Framework.Common;

namespace Seleniums.PageObjects
{
    public class SignInPage:Base
    {
        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.Id, Using = "EmailAddress")]
        private IWebElement EmailAddress;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password;

        [FindsBy(How = How.Id, Using = "signin")]
        private IWebElement signin;

        [FindsBy(How = How.XPath, Using = "//div[@class='form form-login']/form/fieldset/div/div/ul/li")]
        public IWebElement errorText;
        public void SignIn(string username, string password)
        {
            EmailAddress.SendKeys(username);
            Password.SendKeys(password);
            signin.Click();
        }




        


    }
}
