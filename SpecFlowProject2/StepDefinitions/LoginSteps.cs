using TechTalk.SpecFlow;
using NUnit.Framework;
using PageObjectModel.Pages;
using FrameWorkLayer;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps(SeleniumHelper helper)
        {
            _loginPage = new LoginPage(helper);
        }

        [Given(@"the user is on the Swag Labs login page")]
        public void GivenTheUserIsOnTheSwagLabsLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When(@"the user enters valid username ""(.*)""")]
        public void WhenTheUserEntersValidUsername(string username)
        {
            _loginPage.EnterUsername(username);
        }

        [When(@"the user enters valid password ""(.*)""")]
        public void WhenTheUserEntersValidPassword(string password)
        {
            _loginPage.EnterPassword(password);
        }

        [When(@"the user clicks the login button")]
        public void WhenTheUserClicksTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"the user should be redirected to the products page")]
        public void ThenTheUserShouldBeRedirectedToTheProductsPage()
        {
            Assert.IsTrue(_loginPage.IsOnProductsPage(), "User was not redirected to the products page after login.");
        }
    }
}