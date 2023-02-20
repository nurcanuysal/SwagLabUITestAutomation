using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagLabUITestProject.Helpers
{
    public class SeleniumHelpers
    {
        public static IWebDriver InitializeWebDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static WebDriverWait SetWebDriverWait(IWebDriver driver, int waitTime)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
        }
    }
}
