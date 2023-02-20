using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SwagLabUITestProject.Utils
{
    public class ReusableMethods
    {

        // Clicks the Web Element with Javascript Executor
        public static void clickWithJse(WebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.getDriver();
            jse.ExecuteScript("arguments[0].click();", element);
        }

        // SendKeys with Javascript Executor
        public static void sendKeysWithJse(IWebElement element, String text)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.getDriver();
            jse.ExecuteScript("arguments[0].value =’" + text + "’;", element);
        }

        // Clicks By Offset
        public static void clickByOffset(int xOffset, int yOffset)
        {
            Actions actions = new Actions(Driver.getDriver());
            actions.MoveByOffset(xOffset, yOffset).Click().Perform();
        }

        // Scroll Into View
        public static void scrollIntoView(By locator)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.getDriver();
            jse.ExecuteScript("arguments[0].scrollIntoView();", locator);
            Waits.waitForVisibility(locator, 3);
        }





    }
}

