using OpenQA.Selenium;
using FrameWorkLayer;

namespace PageObjectModel.Pages
{
    public class LoginPage
    {
        private readonly SeleniumHelper _helper;

        // Locators
        private readonly By _usernameInput = By.Id("user-name");
        private readonly By _passwordInput = By.Id("password");
        private readonly By _loginButton = By.Id("login-button");

        public LoginPage(SeleniumHelper helper)
        {
            _helper = helper;
        }

        public void NavigateToLoginPage()
        {
            _helper.NavigateToUrl("https://www.saucedemo.com/");
        }

        public void EnterUsername(string username)
        {
            _helper.EnterText(_usernameInput, username);
        }

        public void EnterPassword(string password)
        {
            _helper.EnterText(_passwordInput, password);
        }

        public void ClickLoginButton()
        {
            _helper.ClickElement(_loginButton);
        }

        public bool IsOnProductsPage()
        {
            return _helper.GetCurrentUrl().Contains("/inventory.html");
        }
    }
}