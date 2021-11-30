using System.Data;
using AngleSharp.Text;
using OpenQA.Selenium;
using TestProject1.PageElements;
using TestProject1.PageElements.WebTable;

namespace TestProject1.Pages
{
    public class WebTablesPage : AbstractWebPage
    {
        public WebTablesPage(IWebDriver driver) : base(driver)
        {
        }

        private DemoQaElement _addButton => new(_driver, By.Id("addNewRecordButton"));
        private DemoQaInput _firstNameInput => new(_driver, By.Id("firstName"));
        private DemoQaInput _lastNameInput => new(_driver, By.Id("lastName"));
        private DemoQaInput _userEmailInput => new(_driver, By.Id("userEmail"));
        private DemoQaInput _ageInput => new(_driver, By.Id("age"));
        private DemoQaInput _salaryInput => new(_driver, By.Id("salary"));
        private DemoQaInput _departmentInput => new(_driver, By.Id("department"));
        private DemoQaElement _submitRegFormButton => new(_driver, By.Id("submit"));

        private DemoQaTable _table => new(_driver, By.XPath("//div[@class='rt-table']"));
        private DemoQaInput _jumpToPageInput => new(_driver, By.XPath("//input[@aria-label='jump to page']"));
        private DemoQaElement _totalPagesSpan => new(_driver, By.XPath("//span[@class='-totalPages']"));
        private DemoQaElement _nextDiv => new(_driver, By.XPath("//div[@class='-next']"));
        private DemoQaSelect _rowsPerPageSelect => new(_driver, By.XPath("//select[@aria-label='rows per page']"));

        public void AddRecord(DataRow record)
        {
            _addButton.Click();
            _firstNameInput.SendKeys(record[0].ToString());
            _lastNameInput.SendKeys(record[1].ToString());
            _userEmailInput.SendKeys(record[3].ToString());
            _ageInput.SendKeys(record[2].ToString());
            _salaryInput.SendKeys(record[4].ToString());
            _departmentInput.SendKeys(record[5].ToString());
            _submitRegFormButton.Click();
        }

        public WebTable GetTableFromPage()
        {
            WebTable table = new WebTable();
            _rowsPerPageSelect.SelectByIndex(0);
            for (int x = 1; x <= int.Parse(_totalPagesSpan.Text().Trim()); x++)
            {
                int i = 1;
                while (i <= 5 && _table.IsCellSuits(i, 1))
                {
                    var fName = _table.GetCellFromPage(i, 1);
                    var lName = _table.GetCellFromPage(i, 2);
                    var age = int.Parse(_table.GetCellFromPage(i, 3));
                    var email = _table.GetCellFromPage(i, 4);
                    var salary = int.Parse(_table.GetCellFromPage(i, 5));
                    var department = _table.GetCellFromPage(i, 6);
                    table.AddConcreteRow(fName, lName, age, email, salary, department);
                    i++;
                }
                if (int.Parse(_jumpToPageInput.Text().Trim()) < int.Parse(_totalPagesSpan.Text().Trim()))
                {
                    _nextDiv.Click();
                }
            }

            return table;
        }
    }
}