using OpenQA.Selenium;
using TestProject1.Pages;

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