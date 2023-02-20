using System;
using TechTalk.SpecFlow;
using SwagLabUITestProject.Pages;

namespace SwagLabUITestProject.Steps
{
    [Binding]
    public class AddToCartSteps
    {
        private ProductListingPage productsPage = new ProductListingPage();
        private ShoppingCartPage cartPage = new ShoppingCartPage();

        [When(@"User clicks the add to cart button\t(.*) times")]
        public void WhenUserClicksTheAddToCartButtonTimes(int count)
        {
            productsPage.addToCart(count);

        }

        [When(@"User sees the correct number (.*) on the shopping cart item")]
        public void WhenUserSeesTheCorrectNumberOnTheShoppingCartItem(int count)
        {
            productsPage.checkNumOfCart(count);
        }


        [When(@"User goes to cart page")]
        public void WhenUserGoesToCartPage()
        {
            productsPage.goToCart();
            cartPage.verifyOwnCartPage();
        }

        [When(@"User clicks the remove button (.*) times in product page")]
        public void WhenUserClicksTheRemoveButtonTimesInProductPage(int count)
        {
            productsPage.removeFromCart(count);
        }

        [When(@"User clicks the remove button (.*) times in cart page")]
        public void WhenUserClicksTheRemoveButtonTimesInCartPage(int count)
        {
            cartPage.removeFromCart(count);
        }


        [Then(@"User sees the correct number (.*) on the shopping cart item")]
        public void ThenUserSeesTheCorrectNumberOnTheShoppingCartItem(int count)
        {
            productsPage.checkNumOfCart(count);
        }

        [Then(@"User sees the cart is empty")]
        public void ThenUserSeesTheCartIsEmpty()
        {
            cartPage.verifySelectProductRemoved();
        }


    }
}

