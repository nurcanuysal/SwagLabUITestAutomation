using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages.Components
{
    public abstract class HeaderContainer
    {
        protected IWebDriver driver { get; set; }
        protected WebDriverWait wait { get; set; }

        protected By shoppingCartLinkLocator = By.ClassName("shopping_cart_link");

        public void ClickShoppingCartIcon()
        {
            IWebElement shoppingCartLink = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(shoppingCartLinkLocator));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(shoppingCartLink));
            shoppingCartLink.Click();
        }
    }
}