using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages.Components
{
    public class ProductListingHeaderContainer: HeaderContainer
    {
        public ProductListingHeaderContainer(IWebDriver driver, WebDriverWait wait) 
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(this.driver, this);
        }

    }
}
