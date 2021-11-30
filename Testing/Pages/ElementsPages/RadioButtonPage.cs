using OpenQA.Selenium;
using TestProject1.PageElements;

namespace TestProject1.Pages
{
    public class RadioButtonPage : AbstractWebPage
    {
        public RadioButtonPage(IWebDriver driver) : base(driver)
        {
        }

        private DemoQaRadioButton _yesRBtn => new (_driver, By.XPath("//input[@id='yesRadio']"));
        private DemoQaRadioButton _implressiveRBtn => new (_driver, By.Id("impressiveRadio"));
        private DemoQaRadioButton _noRadioRBtn => new (_driver, By.Id("noRadio"));
        private DemoQaElement _successSpan => new(_driver, By.XPath("//span[@class='text-success']"));

        public bool IsYesRBtnSelected() => _yesRBtn.IsSelected();
        public bool IsImpressiveRBtnSelected() => _implressiveRBtn.IsSelected();
        public bool IsNoRadioRBtnSelected() => _noRadioRBtn.IsSelected();
        public void ClickYesRBtn() => _yesRBtn.Click();
        public void ClickImpressiveRBtn() => _implressiveRBtn.Click();
        public void ClickNoRbtn() => _noRadioRBtn.Click();
        public string GetSuccessSpanText() => _successSpan.Text();
    }
}
