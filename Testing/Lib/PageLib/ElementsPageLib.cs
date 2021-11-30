using OpenQA.Selenium;
using TestProject1.Pages;

namespace Testing.Lib
{
    public class ElementsPageLib
    {
        public readonly CheckBoxPage CheckBoxPage;
        public readonly ElementsPageBase ElementsPageBase;
        public readonly TextBoxPage TextBoxPage;
        public readonly RadioButtonPage RadioButtonPage;
        public readonly WebTablesPage WebTablesPage;

        public ElementsPageLib(IWebDriver driver)
        {
            ElementsPageBase = new ElementsPageBase(driver);
            TextBoxPage = new TextBoxPage(driver);
            CheckBoxPage = new CheckBoxPage(driver);
            RadioButtonPage = new RadioButtonPage(driver);
            WebTablesPage = new WebTablesPage(driver);
        }
    }
}