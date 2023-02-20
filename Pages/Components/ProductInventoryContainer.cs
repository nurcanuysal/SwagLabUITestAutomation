using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages.Components
{
    public class ProductInventoryContainer
    {
        protected IWebDriver driver { get; set; }
        protected WebDriverWait wait { get; set; }

        public ProductInventoryContainer(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(this.driver, this);
        }

        private By inventoryListLocator = By.ClassName("inventory_list");
        private string productAddToChartBtnName = "button[name='add-to-cart-{{productName}}']"; //add-to-cart-sauce-labs-bolt-t-shirt

        private string GenerateProductAddToChartBtnLocator(string productName) 
        {
            string name = productName.ToLower().Replace(" ", "-");
            return this.productAddToChartBtnName.Replace("{{productName}}",name);
        }
        public void AddToChart(string productName) 
        {
            string AddToChartBtnLocator = this.GenerateProductAddToChartBtnLocator(productName);
            var addToChartBtn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(AddToChartBtnLocator)));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(addToChartBtn));
            addToChartBtn.Click();
        }

    }
}
