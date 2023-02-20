using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SwagLabUITestProject.Utils
{
    public class Driver
    {
        private static WebDriver _webDriver;

        private Driver()
        {
        }
        public static WebDriver getDriver()
        {
            if (_webDriver == null)
            {
                _webDriver = new ChromeDriver();
            }
            _webDriver.Manage().Window.Maximize();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _webDriver.Url = "https://www.saucedemo.com/";
            return _webDriver;
        }

        public static void closeDriver()
        {

            if (_webDriver != null)
            {
                Driver.getDriver().Close();
                _webDriver = null;
            }

        }

        public static void NavigateUrl(string url)
        {

            Driver.getDriver().Navigate().GoToUrl(url);
        }

        public static void NavigateBack()
        {
            Driver.getDriver().Navigate().Back();
        }
    }
}

