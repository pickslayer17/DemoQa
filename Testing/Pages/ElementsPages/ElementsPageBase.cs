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
        

        private Li _textBoxLi =>
            new Li(Driver, By.XPath("//div[contains(@class,'element-list')][1]//li[@id='item-0']"));

        public void ClickTextBoxLi()
        {
            _textBoxLi.Click();
        }
    }
}