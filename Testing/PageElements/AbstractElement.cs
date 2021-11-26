using OpenQA.Selenium;

namespace TestProject1.PageElements
{
    public class AbstractElement
    {
        protected IWebElement _webElement;

        protected AbstractElement(IWebDriver driver, By locator)
        {
            
        }

        public virtual void Click()
        {
            _webElement.Click();
        }
    }
}