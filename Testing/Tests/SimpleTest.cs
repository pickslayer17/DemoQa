using System.Threading;
using NUnit.Framework;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    public class SimpleTest : AbstractTest
    {
        [Test]
        public void Simple()
        {
            App.Flow.GoTo(ElementsPageBase.URL);
            App.Pages.ElementsPageLib.ElementsPageBase.ClickTextBoxLi();
            App.Pages.ElementsPageLib.TextBoxPage.WaitForPageLoad();
        }
    }
}