using SwagLabUITestProject.Pages.Components;
using SwagLabUITestProject.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabUITestProject.Pages
{
    public class ProductListingPage
    {
        private IWebDriver _driver;
        private IWebElement _productsLabel => _driver.FindElement(By.XPath("u//span[text()='Products']"));
        private IList<IWebElement> _addToCartButtons => _driver.FindElements(By.XPath("//button[contains(@id,'add-to-cart')]"));
        private IList<IWebElement> _removeButtons => _driver.FindElements(By.XPath("//button[contains(@id,'remove')]"));
        private IWebElement _shoppingCartButton => _driver.FindElement(By.ClassName("shopping_cart_badge"));
        private IWebElement _sortDropDown => _driver.FindElement(By.XPath("//select[@class='product_sort_container']"));
        private IList<IWebElement> productsPriceList => _driver.FindElements(By.ClassName("inventory_item_price"));
        private IList<IWebElement> productsNameList => _driver.FindElements(By.ClassName("inventory_item_name"));
        private IEnumerable<string> GetListOfProductsNames() => productsNameList.Select(element => element.Text).ToArray();
        public IEnumerable<decimal> GetListOfProductsPrices() => productsPriceList.Select(e => decimal.Parse(e.Text, NumberStyles.Currency, new CultureInfo("en-US")));
        public ProductListingPage()
        {
            _driver = Driver.getDriver();
        }

        public void verifyProductPage()
        {
            Asserts.assertTrue(_productsLabel.Displayed);
        }
        public void addToCart(int count)
        {
            Console.WriteLine(_addToCartButtons.Count);
            for (int i = 0; i < count; i++)
            {
                _addToCartButtons.ElementAt(i).Click();
            }
        }

        public void removeFromCart(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _removeButtons.ElementAt(i).Click();
            }
        }

        public void checkNumOfCart(int expectedCount)
        {
            int actualCount = Int32.Parse(_shoppingCartButton.Text);
            Asserts.assertEquals(expectedCount, actualCount);
        }
        public void goToCart()
        {
            _shoppingCartButton.Click();
        }

        public void selectSortDropDown(string option)
        {
            SelectElement sortOPT = new SelectElement(_sortDropDown);
            sortOPT.SelectByText(option);
        }
        public bool CheckProductsInOrder(string option)
        {
            switch (option)
            {
                case "descending":
                    return !CheckProductsSortedAlphabetically(false);
                    break;
                case "ascending":
                    return CheckProductsSortedAlphabetically(true);
                    break;
                case "Price low to high":
                    return CheckProductsSortedHighToLow(true);
                    break;
                case "Price high to low":
                    return !CheckProductsSortedHighToLow(false);
                    break;
                default:
                    return false;
                    break;
            }
        }

        public bool CheckProductsSortedAlphabetically(bool alphabetical)
        {
            IEnumerable<string> sortedArray;
            if (alphabetical) sortedArray = GetListOfProductsNames().OrderBy(element => element);
            else sortedArray = GetListOfProductsNames().OrderByDescending(element => element);
            return GetListOfProductsNames().SequenceEqual(sortedArray);
        }

        public bool CheckProductsSortedHighToLow(bool highToLow)
        {
            IEnumerable<decimal> sortedArray;
            if (highToLow) sortedArray = GetListOfProductsPrices().OrderBy(element => element);
            else sortedArray = GetListOfProductsPrices().OrderByDescending(element => element);
            return GetListOfProductsPrices().SequenceEqual(sortedArray);
        }
    }
}
