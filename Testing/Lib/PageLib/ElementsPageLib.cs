using OpenQA.Selenium;
using TestProject1.Pages;

namespace Testing.Lib
{
    public class ElementsPageLib
    {
        public readonly ElementsPageBase ElementsPageBase;
        public readonly TextBoxPage TextBoxPage;

        public ElementsPageLib(IWebDriver driver)
        {
            ElementsPageBase = new ElementsPageBase(driver);
            TextBoxPage = new TextBoxPage(driver);
        }
    }
}