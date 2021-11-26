using OpenQA.Selenium;

namespace Testing.Lib
{
    public class AppLib
    {
        public readonly FlowLib Flow;
        public readonly PageLibBase Pages;

        public AppLib(IWebDriver driver)
        {
            Pages = new PageLibBase(driver);
            Flow = new FlowLib(driver);
        }
    }
}