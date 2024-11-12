using TechTalk.SpecFlow;
using PageObjectModel.Pages;
using FrameWorkLayer;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver driver)
        {
            var helper = new SeleniumHelper(driver);
            _loginPage = new LoginPage(helper);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _loginPage.NavigateToLoginPage("http://example.com/login");
        }

        [When(@"I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            _loginPage.EnterUsername("validuser");
            _loginPage.EnterPassword("validpassword");
        }

        [When(@"I enter ""(.*)"" and ""(.*)""")]
        public void WhenIEnterAnd(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            // Add assertion for successful login
            // This might involve checking for a welcome message or a dashboard element
            Assert.IsTrue(true, "Placeholder for successful login assertion");
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_loginPage.IsErrorMessageDisplayed(), "Error message should be displayed");
        }
    }
}