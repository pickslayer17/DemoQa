using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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
            new Actions(_driver).MoveToElement(_webElement).Click(_webElement).Perform();
        }
    }
}