using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Seleniums.PageObjects;

namespace Seleniums.Tests.LoginTest
{
    [TestFixture()]
    class SignUpTest:SetUpLogic
    {

        [Test]
        public void Verify_SignInWithInvalidCredentials()
        {
            SearchPage searchPage=new SearchPage(this.driver);
            SignInPage signInPage= searchPage.GotoSignInPage();
            signInPage.SignIn("pravin@gmail.com","1234");
            signInPage.errorText.Text.Should().NotBeNullOrEmpty();

        }

    }
}
