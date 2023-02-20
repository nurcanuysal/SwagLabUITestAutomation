using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages
{
    public class ChecoutOverviewPage
    {
        protected IWebDriver driver { get; set; }
        protected WebDriverWait wait { get; set; }

        public ChecoutOverviewPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(this.driver, this);
        }

        private By finishBtnLocator = By.Id("finish");

        public void Finish()
        {
            IWebElement btn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(finishBtnLocator));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(btn));
            btn.Click();
        }
    }
}
