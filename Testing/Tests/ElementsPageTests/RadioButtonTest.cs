using System.Threading;
using NuGet.Frameworks;
using NUnit.Framework;
using TestProject1.Pages;

namespace TestProject1.Tests.ElementsPageTests
{
    public class RadioButtonTest : AbstractTest
    {
        [Test]
        public void RadioButtonCheck()
        {
            App.Flow.GoTo(ElementsPageBase.URL);
            App.Pages.ElementsPageLib.ElementsPageBase.WaitForPageLoad();
            App.Pages.ElementsPageLib.ElementsPageBase.GoToRadioButton();
            App.Pages.ElementsPageLib.RadioButtonPage.WaitForPageLoad();
            App.Pages.ElementsPageLib.RadioButtonPage.ClickYesRBtn();
            var expectedOfYes = "Yes";
            Assert.That(expectedOfYes == App.Pages.ElementsPageLib.RadioButtonPage.GetSuccessSpanText());
            Assert.That(App.Pages.ElementsPageLib.RadioButtonPage.IsYesRBtnSelected());

            App.Pages.ElementsPageLib.RadioButtonPage.ClickImpressiveRBtn(); 
            expectedOfYes = "Impressive";
            Assert.That(expectedOfYes == App.Pages.ElementsPageLib.RadioButtonPage.GetSuccessSpanText());
            Assert.That(!(App.Pages.ElementsPageLib.RadioButtonPage.IsYesRBtnSelected()));
            Assert.That(App.Pages.ElementsPageLib.RadioButtonPage.IsImpressiveRBtnSelected());

            // Assert.That(() => App.Pages.ElementsPageLib.RadioButtonPage.ClickNoRbtn(), Throws.Exception);
            // Assert.Throws<Exception>(() => method());
            App.Pages.ElementsPageLib.RadioButtonPage.ClickNoRbtn();
            Assert.That(!(App.Pages.ElementsPageLib.RadioButtonPage.IsNoRadioRBtnSelected()));

        }
        
        
    }
}