using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabUITestProject.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Tests
{
    [TestClass]
    public class SwagLabProductPurchasingTests : BaseTest
    {
        [TestMethod]
        public void ProductPurchaseTest()
        {
            ProductListingPage productListingPage = new ProductListingPage();
            productListingPage.goToCart();
            productListingPage.verifyProductPage();
            ShoppingCartPage shoppingCart = new ShoppingCartPage();
            shoppingCart.clicksOnCheckOutBTN();
            shoppingCart.verifyOwnCartPage();
            shoppingCart.verifySelectProductRemoved();
            CheckOutInformationPage checkOutInformationPage = new CheckOutInformationPage(driver, wait);
            checkOutInformationPage.EnterInformation("TestName", "TestLastName", "90807");
            ChecoutOverviewPage overviewPage = new ChecoutOverviewPage(driver, wait);
            ChecoutOverviewPage checkOutOverviewPage = new ChecoutOverviewPage(driver, wait);
            checkOutOverviewPage.Finish();

        }
    }
}
