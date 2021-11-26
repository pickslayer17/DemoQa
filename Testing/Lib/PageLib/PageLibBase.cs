using OpenQA.Selenium;

namespace Testing.Lib
{
    public class PageLibBase
    {
        public readonly ElementsPageLib ElementsPageLib;

        public PageLibBase(IWebDriver driver)
        {
            ElementsPageLib = new ElementsPageLib(driver);
        }
    }
}