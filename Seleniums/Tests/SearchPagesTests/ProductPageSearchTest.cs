using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Seleniums.PageObjects;

namespace Seleniums.Tests
{
    [TestFixture]
    class ProductPageSearchTest:SetUpLogic
    {
        [Test]
        public void When_i_SearchForCheapestT_Shirt_Then_Product_Page_should_display_Cheapest_TShirt()
        {
            SearchPage searchPage=new SearchPage(driver);
            ProductSearchResults productSearchResults= searchPage.SearchForProduct("Jeans");
            driver=productSearchResults.SortProductBasedOn_PriceLowToHigh();
            var cheapTshirts = productSearchResults.GetListOfCheapTshirts(driver);
            cheapTshirts.Should().NotBeNullOrEmpty("No cheap Tshirt returns from search web page");
        }
    }
}
