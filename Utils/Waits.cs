using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Threading.Tasks;

namespace SwagLabUITestProject.Utils
{
	public class Waits
	{
            private static WebDriverWait _wait;

            // Wait For - Hard Wait
            public static void waitFor(int sec)
            {
                try
                {
                    Thread.Sleep(sec * 1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            // Wait For Visibility
            public static void waitForVisibility(By locator, int timeout)
            {
                try
                {
                    _wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(timeout));
                    _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }

            // Wait For Clickablility
            public static void waitForClickablility(IWebElement element, int timeout)
            {
                try
                {
                    _wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(timeout));
                    _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


        }
    }
}

