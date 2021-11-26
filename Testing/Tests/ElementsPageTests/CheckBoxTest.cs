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
            App.Pages.ElementsPageLib.ElementsPageBase.ClickCheckBoxLi();
        }
    }
}