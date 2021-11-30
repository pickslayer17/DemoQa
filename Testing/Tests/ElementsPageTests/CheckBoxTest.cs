using System.Threading;
using NUnit.Framework;
using TestProject1.Pages;

namespace TestProject1.Tests.ElementsPageTests
{
    public class CheckBoxTest : AbstractTest
    {
        [Test]
        public void Smoke_CheckTreeTest()
        {
            App.Flow.GoTo(ElementsPageBase.URL);
            App.Pages.ElementsPageLib.ElementsPageBase.WaitForPageLoad();
            App.Pages.ElementsPageLib.ElementsPageBase.GoToCheckBox();
            App.Pages.ElementsPageLib.CheckBoxPage.WaitForPageLoad();
            App.Pages.ElementsPageLib.CheckBoxPage.ExpandAll();
            App.Pages.ElementsPageLib.CheckBoxPage.CheckSpan(CheckBoxPage.Spans.Desktop);
            App.Pages.ElementsPageLib.CheckBoxPage.CheckSpan(CheckBoxPage.Spans.Workspace);
            App.Pages.ElementsPageLib.CheckBoxPage.CheckSpan(CheckBoxPage.Spans.Public);
            App.Pages.ElementsPageLib.CheckBoxPage.CheckSpan(CheckBoxPage.Spans.Private);
            App.Pages.ElementsPageLib.CheckBoxPage.CheckSpan(CheckBoxPage.Spans.Downloads);
            var expectedResult = "desktop notes commands workspace react angular veu public private downloads wordFile excelFile";
            Assert.That(expectedResult ==  App.Pages.ElementsPageLib.CheckBoxPage.GetFinalSpansText());
        }
    }
}