using OpenQA.Selenium;
using TestProject1.PageElements;

namespace TestProject1.Pages
{
    public class TextBoxPage : ElementsPageBase
    {
        public TextBoxPage(IWebDriver driver) : base(driver)
        {
        }

        private DemoQaInput _fullNameInput => new(_driver, By.Id("userName"));
        private DemoQaInput _emailInput => new(_driver, By.Id("userEmail"));
        private DemoQaInput _currentAddressInput => new(_driver, By.Id("currentAddress"));
        private DemoQaInput _permanentAddressInput => new(_driver, By.Id("permanentAddress"));
        private DemoQaSubmitButton _submitButton => new(_driver, By.Id("submit"));
        private DemoQaP _nameP => new(_driver, By.XPath("//div[contains(@class, 'border')]/p[@id='name']"));
        private DemoQaP _emailP => new(_driver, By.XPath("//div[contains(@class, 'border')]/p[@id='email']"));

        private DemoQaP _currentAddressP =>
            new(_driver, By.XPath("//div[contains(@class, 'border')]/p[@id='currentAddress']"));

        private DemoQaP _permanentAddressP => new(_driver,
            By.XPath("//div[contains(@class, 'border')]/p[@id='permanentAddress']"));


        public string GetFinalText()
        {
            return _nameP.Text() + _emailP.Text() + _currentAddressP.Text() + _permanentAddressP.Text();
        }

        public bool IsEmailInputBorderRed()
        {
            return _emailInput.IsBorderColorRed();
        }

        public void FillFullName(string text)
        {
            _fullNameInput.SendKeys(text);
        }

        public void FillEmail(string text)
        {
            _emailInput.SendKeys(text);
        }

        public void FillCurrentAddress(string text)
        {
            _currentAddressInput.SendKeys(text);
        }

        public void FillPermanentAddress(string text)
        {
            _permanentAddressInput.SendKeys(text);
        }

        public void ClickSubmit()
        {
            _submitButton.Click();
        }
    }
}