using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject1.Pages
{
    public abstract class AbstractWebPage
    {
        protected readonly IWebDriver Driver;
        // public static string URL { get; protected set; }
        

        protected AbstractWebPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public virtual void WaitForPageLoad()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(TestSettings.Timeout)).Until(
                ExpectedConditions.ElementExists(By.XPath("//body")));
        }
    }
}