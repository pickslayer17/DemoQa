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

        private DemoQaLi TextBoxDemoQaLi =>
            new(_driver, By.XPath("(//div[contains(@class,'element-list')])[1]//li[@id='item-0']"));

        private DemoQaLi CheckBoxLi =>
            new(_driver, By.XPath("(//div[contains(@class,'element-list')])[1]//li[@id='item-1']"));

        public void ClickTextBoxLi()
        {
            TextBoxDemoQaLi.Click();
        }

        public void ClickCheckBoxLi()
        {
            CheckBoxLi.Click();
        }
    }
}