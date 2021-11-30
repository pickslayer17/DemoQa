using OpenQA.Selenium;
using TestProject1.PageElements;

namespace TestProject1.Pages
{
    public class ElementsPageBase : AbstractWebPage
    {
        public static string URL = "https://demoqa.com/elements";

        public ElementsPageBase(IWebDriver driver) : base(driver)
        {
        }

        private DemoQaLi _textBoxDemoQaLi =>
            new(_driver, By.XPath("(//div[contains(@class,'element-list')])[1]//li[@id='item-0']"));

        private DemoQaLi _checkBoxLi =>
            new(_driver, By.XPath("(//div[contains(@class,'element-list')])[1]//li[@id='item-1']"));

        private DemoQaLi _radioButtonLi =>
            new(_driver, By.XPath("(//div[contains(@class,'element-list')])[1]//li[@id='item-2']"));
        private DemoQaLi _WebTableLi =>
            new(_driver, By.XPath("(//div[contains(@class,'element-list')])[1]//li[@id='item-3']"));

        public void GoToTextBox() => _textBoxDemoQaLi.Click();

        public void GoToCheckBox() =>_checkBoxLi.Click();

        public void GoToRadioButton() => _radioButtonLi.Click();

        public void GoToWebTables() => _WebTableLi.Click();
    }
}