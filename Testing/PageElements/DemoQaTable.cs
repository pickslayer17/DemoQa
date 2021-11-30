using System;
using System.Collections.ObjectModel;
using System.Data;
using AngleSharp.Common;
using OpenQA.Selenium;

namespace TestProject1.PageElements
{
    public class DemoQaTable : DemoQaElement
    {
        private WebTable.WebTable _webTable;

        public DemoQaTable(IWebDriver driver, By locator) : base(driver, locator)
        {
        }


        public bool IsCellSuits(int i, int j)
        {
            if (!IsCellExists(i, j)) return false;
            var val = GetCellFromPage(i, j);
            if (val == "" || val == " ") return false;
            return true;
        }

        private bool IsCellExists(int i, int j)
        {
            try
            {
                GetCellFromPage(i, j);
            }
            catch (NoSuchElementException ex)
            {
                Console.Out.WriteLine("Out of bounce while verfifying is element exists");
                Console.WriteLine(Environment.StackTrace);
                Console.Out.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }

        public string GetCellFromPage(int i, int j)
        {
            return _webElement.FindElement(By.XPath($"//div[@class='rt-tr-group'][{i}]//div[@class='rt-td'][{j}]"))
                .Text;
        }
    }
}