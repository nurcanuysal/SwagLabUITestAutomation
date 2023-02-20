using System;
using SwagLabUITestProject.Pages;
using TechTalk.SpecFlow;

namespace SwagLabUITestProject.Steps
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage = new LoginPage();

        [Given(@"User navigates to login page")]
        public void GivenUserNavigatesToLoginPage()
        {
            loginPage.NavigatesToLoginPage();
        }

        [When(@"User enters credentials '(.*)' and '(.*)'")]
        public void WhenUserEntersCredentialsAnd(string username, string password)
        {
            loginPage.enterCredentials(username, password);
        }

        [When(@"User clicks the login button")]
        public void WhenUserClicksTheLoginButton()
        {
            loginPage.clickLoginButton();
        }

        [Then(@"User sees the products")]
        public void ThenUserSeesTheProducts()
        {
            loginPage.CheckValidLogin();
        }

        [Then(@"User sees the locked out user message")]
        public void ThenUserSeesTheLockedOutUserMessage()
        {
            loginPage.CheckInvalidLoginForLockedUser();
        }

        [Then(@"User sees the problem user images")]
        public void ThenUserSeesTheProblemUserImages()
        {
            loginPage.CheckLoginForProblemUser();
        }

        [Then(@"User sees the error message")]
        public void ThenUserSeesTheErrorMessage()
        {
            loginPage.CheckInvalidLogin();
        }

    }
}

