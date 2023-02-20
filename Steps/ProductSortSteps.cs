using System;
using SwagLabUITestProject.Utils;
using TechTalk.SpecFlow;
using SwagLabUITestProject.Pages;

namespace SwagLabUITestProject.Steps
{
    [Binding]
    public class ProductSortSteps
    {
        ProductListingPage productsPage = new ProductListingPage();

        [When(@"User select '(.*)' option in the sort dropdown")]
        public void WhenUserSelectOptionInTheSortDropdown(string option)
        {
            productsPage.selectSortDropDown(option);
        }

        [Then(@"User sees products are sorted in '(.*)' order")]
        public void ThenUserSeesProductsAreSortedInOrder(string option)
        {
            Asserts.assertTrue(productsPage.CheckProductsInOrder(option));
        }

    }
}

