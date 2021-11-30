using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject1.PageElements
{
    public class DemoQaSelect :DemoQaElement
    {
        public DemoQaSelect(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        public void SelectByValue(string value)
        {
            SelectElement selectElement = new SelectElement(_webElement);
            selectElement.SelectByValue(value);
        }
        public void SelectByIndex(int index)
        {
            SelectElement selectElement = new SelectElement(_webElement);
            selectElement.SelectByIndex(index);
        }
    }
}