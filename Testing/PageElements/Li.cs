using OpenQA.Selenium;

namespace TestProject1.PageElements
{
    public class Li: AbstractElement
    {
        public Li(IWebDriver driver, By locator) : base(driver, locator)
        {
            _webElement = driver.FindElement(locator);
        }

        
    }
}