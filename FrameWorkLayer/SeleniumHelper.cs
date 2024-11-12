using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace FrameWorkLayer
{
    public class SeleniumHelper
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public SeleniumHelper(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public IWebElement WaitAndFindElement(By locator)
        {
            return _wait.Until(d => d.FindElement(locator));
        }

        public void ClickElement(By locator)
        {
            WaitAndFindElement(locator).Click();
        }

        public void EnterText(By locator, string text)
        {
            WaitAndFindElement(locator).SendKeys(text);
        }

        public string GetElementText(By locator)
        {
            return WaitAndFindElement(locator).Text;
        }

        public bool IsElementDisplayed(By locator)
        {
            try
            {
                return WaitAndFindElement(locator).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}