using OpenQA.Selenium;
using TestProject1.PageElements;

namespace TestProject1.Pages
{
    public class RadioButtonPage : AbstractWebPage
    {
        public RadioButtonPage(IWebDriver driver) : base(driver)
        {
        }

        private DemoQaRadioButton _yesRadioButton => new (_driver, By.XPath("//input[@id='yesRadio']"));
        private DemoQaRadioButton _implressiveRadioButton => new (_driver, By.Id("impressiveRadio"));
        private DemoQaRadioButton _noRadioRadioButton => new (_driver, By.Id("noRadio"));
        private DemoQaElement _successSpan => new(_driver, By.XPath("//span[@class='text-success']"));

        public bool IsYesRBtnSelected() => _yesRadioButton.IsSelected();
        public bool IsImpressiveRBtnSelected() => _implressiveRadioButton.IsSelected();
        public bool IsNoRadioRBtnSelected() => _noRadioRadioButton.IsSelected();
        public void ClickYesRBtn() => _yesRadioButton.Click();
        public void ClickImpressiveRBtn() => _implressiveRadioButton.Click();
        public void ClickNoRbtn() => _noRadioRadioButton.Click();
        public string GetSuccessSpanText() => _successSpan.Text();
    }
}
