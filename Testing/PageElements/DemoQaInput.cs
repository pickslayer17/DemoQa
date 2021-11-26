using OpenQA.Selenium;

namespace TestProject1.PageElements
{
    public class DemoQaInput : AbstractElement
    {
        public DemoQaInput(IWebDriver driver, By locator) : base(driver, locator)
        {
        }


        public string BorderColor => _webElement.GetCssValue("border-color");

        public bool IsBorderColorRed()
        {
            return BorderColor == "rgb(255, 0, 0)";
        }
    }
}