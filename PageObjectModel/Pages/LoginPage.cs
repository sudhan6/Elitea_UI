using OpenQA.Selenium;
using FrameWorkLayer;

namespace PageObjectModel.Pages
{
    public class LoginPage
    {
        private readonly SeleniumHelper _helper;

        // Locators
        private readonly By _usernameField = By.Id("username");
        private readonly By _passwordField = By.Id("password");
        private readonly By _loginButton = By.Id("login-button");
        private readonly By _errorMessage = By.Id("error-message");

        public LoginPage(SeleniumHelper helper)
        {
            _helper = helper;
        }

        public void NavigateToLoginPage(string url)
        {
            _helper.NavigateToUrl(url);
        }

        public void EnterUsername(string username)
        {
            _helper.EnterText(_usernameField, username);
        }

        public void EnterPassword(string password)
        {
            _helper.EnterText(_passwordField, password);
        }

        public void ClickLoginButton()
        {
            _helper.ClickElement(_loginButton);
        }

        public bool IsErrorMessageDisplayed()
        {
            return _helper.IsElementDisplayed(_errorMessage);
        }

        public string GetErrorMessage()
        {
            return _helper.GetElementText(_errorMessage);
        }
    }
}