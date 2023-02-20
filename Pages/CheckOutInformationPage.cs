using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Pages
{
    public class CheckOutInformationPage
    {
        protected IWebDriver driver { get; set; }
        protected WebDriverWait wait { get; set; }

        public CheckOutInformationPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(this.driver, this);
        }

        private By nameFieldLocator = By.Id("first-name");
        private By lastNameFieldLocator = By.Id("last-name");
        private By postalCodeFieldLocator = By.Id("postal-code");
        private By continuetBtnLocator = By.Id("continue");

        private void Continue()
        {
            IWebElement btn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(continuetBtnLocator));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(btn));
            btn.Click();
        }
        private void EnterFirstName(string firstName)
        {
            IWebElement nameField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(nameFieldLocator));
            nameField.SendKeys(firstName);
        }
        private void EnterLastName(string lastname)
        {
            IWebElement lastNameField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(lastNameFieldLocator));
            lastNameField.SendKeys(lastname);
        }
        private void EnterPostalCode(string postalCode)
        {
            IWebElement postalCodeField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(postalCodeFieldLocator));
            postalCodeField.SendKeys(postalCode);
        }

        public void EnterInformation(string firstName, string lastname, string postalCode)
        {
            this.EnterFirstName(firstName);
            this.EnterLastName(lastname);
            this.EnterPostalCode(postalCode);
            this.Continue();
        }
    }
}
