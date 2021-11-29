using OpenQA.Selenium;

namespace TestProject1.PageElements
{
    public class DemoQaRadioButton : DemoQaElement
    {
        public DemoQaRadioButton(IWebDriver driver, By locator) : base(driver, locator)
        {
        }

        public bool IsSelected() => _webElement.Selected;
        public override void Click()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", _webElement);
        }
    }
}