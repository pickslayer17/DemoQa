using OpenQA.Selenium;

namespace TestProject1.PageElements
{
    public class AbstractElement
    {
        protected readonly IWebElement _webElement;

        protected AbstractElement(IWebDriver driver, By locator)
        {
            _webElement = driver.FindElement(locator);
        }

        public virtual string Text()
        {
            return _webElement.Text;
        }

        public virtual void Clear()
        {
            _webElement.Clear();
        }

        public virtual void Click()
        {
            _webElement.Click();
        }

        public virtual void SendKeys(string text)
        {
            _webElement.SendKeys(text);
        }
    }
}