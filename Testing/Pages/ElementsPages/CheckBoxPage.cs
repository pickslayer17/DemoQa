

using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;
using TestProject1.PageElements;

namespace TestProject1.Pages
{
    public class CheckBoxPage : AbstractWebPage
    {
        public CheckBoxPage(IWebDriver driver) : base(driver)
        {
        }

        private DemoQaElement _expandAll =>
            new DemoQaCollapseButton(_driver, By.XPath("//button[contains(@class,'rct-option-expand-all')]"));
        private ReadOnlyCollection<DemoQaElement> _treeSpans => 
            DemoQaElement.FindCollection(_driver, By.XPath("(//div[contains(@class,'react-checkbox-tree')]//ol)[1]//span[@class='rct-title']"));

        private ReadOnlyCollection<DemoQaElement> _finalTextSpans => 
            DemoQaElement.FindCollection(_driver, By.XPath("//span[@class='text-success']"));
        


        public void ExpandAll() => _expandAll.Click();

        public void CheckSpan(Spans spanName) => _treeSpans[(int)spanName].Click();

        public string GetFinalSpansText()
        {
            StringBuilder sb = new();
            foreach (var element in _finalTextSpans)
            {
                sb.Append(element.Text().Trim() + " ");
            }
            return sb.ToString().Trim();
        }
        public enum Spans
        {
            Home = 0,
            Desktop = 1,
            Notes = 2,
            Commands = 3,
            Documents = 4,
            Workspace = 5,
            React = 6,
            Angular = 7,
            Veu = 8,
            Office = 9,
            Public = 10,
            Private = 11,
            Classifield = 12,
            General = 13,
            Downloads = 14,
            World_File_doc = 15,
            Excel_File_doc = 16
            
        }
    }
}