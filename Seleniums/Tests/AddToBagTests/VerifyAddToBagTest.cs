using System;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Seleniums.PageObjects;
using Excel=Microsoft.Office.Interop.Excel;

namespace Seleniums.Tests.AddToBagTests
{
   public class VerifyAddToBagTest:SetUpLogic
    {   
        [Test]
        public void Verify_ProductIsVisibleInBag_After_AddingProductToBag()
        {
            SearchPage searchPage = new SearchPage(this.driver);
            ProductSearchResults productSearchResults = searchPage.SearchForProduct("Jeans");

            driver = productSearchResults.SortProductBasedOn_PriceLowToHigh();
            ProductPage productPage = productSearchResults.SelectAnyRandomProduct();
            BagPage bagPage=productPage.AddtoBagProduct();
            var productNameFromBag=bagPage.GetProductNameFromBag(driver);
            ProductSearchResults.productName.Should().Be(productNameFromBag);
        }
    }
}
