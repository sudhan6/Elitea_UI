using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkLayer
{
    public class SeleniumHelper
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

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

        public void EnterText(By locator, string text)
        {
            WaitAndFindElement(locator).SendKeys(text);
        }

        public void ClickElement(By locator)
        {
            WaitAndFindElement(locator).Click();
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

        public string GetCurrentUrl()
        {
            return _driver.Url;
        }

        // Add more helper methods as needed
    }
}