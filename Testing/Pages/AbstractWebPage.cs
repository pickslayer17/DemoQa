using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject1.Pages
{
    public abstract class AbstractWebPage
    {
        protected readonly IWebDriver _driver;

        protected AbstractWebPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public virtual void WaitForPageLoad()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(TestSettings.Timeout)).Until(
                ExpectedConditions.ElementExists(By.XPath("//body")));
        }
    }
}