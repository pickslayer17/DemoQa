using System;
using System.Data;
using System.Threading;
using NUnit.Framework;
using TestProject1.PageElements.WebTable;
using TestProject1.Pages;

namespace TestProject1.Tests.ElementsPageTests
{
    public class WebTableTest : AbstractTest
    {
        [Test]
        public void EditTableTest()
        {
            App.Flow.GoTo(ElementsPageBase.URL);
            App.Pages.ElementsPageLib.ElementsPageBase.WaitForPageLoad();
            App.Pages.ElementsPageLib.ElementsPageBase.GoToWebTables();

            WebTable tableFromPage = App.Pages.ElementsPageLib.WebTablesPage.GetTableFromPage();
            tableFromPage.PrintTableOut();

            WebTable etalonTable = tableFromPage;
            etalonTable.AddDefaultRow();
            App.Pages.ElementsPageLib.WebTablesPage.AddRecord(etalonTable.GetLastRow());
            tableFromPage = App.Pages.ElementsPageLib.WebTablesPage.GetTableFromPage();
            Assert.That(etalonTable.Equals(tableFromPage));

            App.Pages.ElementsPageLib.WebTablesPage.AddRecord(etalonTable.GetLastRow());
            App.Pages.ElementsPageLib.WebTablesPage.AddRecord(etalonTable.GetLastRow());
            App.Pages.ElementsPageLib.WebTablesPage.AddRecord(etalonTable.GetLastRow());

            tableFromPage = App.Pages.ElementsPageLib.WebTablesPage.GetTableFromPage();
            tableFromPage.PrintTableOut();
        }
    }
}