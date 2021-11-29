using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AngleSharp.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject1.PageElements
{
    public class DemoQaElement  
    {
        protected readonly IWebElement _webElement;

        protected DemoQaElement(IWebDriver driver, By locator)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(TestSettings.Timeout)).Until(
                ExpectedConditions.ElementExists(locator));
            _webElement = driver.FindElement(locator);
        }

        private DemoQaElement(IWebElement webElement)
        {
            _webElement = webElement;
        }

        public static ReadOnlyCollection<DemoQaElement> FindCollection(IWebDriver driver, By locator)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(TestSettings.Timeout)).Until(
                ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            ReadOnlyCollection<IWebElement> webElements = driver.FindElements(locator);
            List<DemoQaElement> elementsList = new ();
            foreach (var webElement in webElements)
            {
                elementsList.Add(new DemoQaElement(webElement));
            }
            return new ReadOnlyCollection<DemoQaElement>(elementsList);
        }

        public virtual string Text()
        {
            return _webElement.Text;
        }

        public virtual void Clear()
        {
            _webElement.Clear();
        }

        public virtual void Click()
        {
            _webElement.Click();
        }

        public virtual void SendKeys(string text)
        {
            _webElement.SendKeys(text);
        }
    }
}