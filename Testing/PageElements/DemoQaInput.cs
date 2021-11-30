using OpenQA.Selenium;

namespace TestProject1.PageElements
{
    public class DemoQaInput : DemoQaElement
    {
        public DemoQaInput(IWebDriver driver, By locator) : base(driver, locator)
        {
        }


        public string BorderColor => _webElement.GetCssValue("border-color");

        public bool IsBorderColorRed()
        {
            return BorderColor == "rgb(255, 0, 0)";
        }

        public override string Text()
        {
            return _webElement.GetAttribute("value");
        }
    }
}