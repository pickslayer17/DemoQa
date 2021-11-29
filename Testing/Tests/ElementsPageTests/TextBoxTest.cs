using System.Threading;
using NUnit.Framework;
using TestProject1.Pages;

namespace TestProject1.Tests.ElementsPageTests
{
    public class TextBoxTest : AbstractTest
    {
        [Test]
        public void Smoke_BorderColorTest()
        {
            App.Flow.GoTo(ElementsPageBase.URL);
            App.Pages.ElementsPageLib.ElementsPageBase.WaitForPageLoad();
            App.Pages.ElementsPageLib.ElementsPageBase.ClickTextBoxLi();
            App.Pages.ElementsPageLib.TextBoxPage.WaitForPageLoad();
            var name = "Johnny";
            var email = "asd@mail.ru";
            var currentAddress = "Ocassion street, bla bla bla";
            var permanentAddress = "Minsk city, kazinca street";
            App.Pages.ElementsPageLib.TextBoxPage.FillFullName(name);
            App.Pages.ElementsPageLib.TextBoxPage.FillEmail(email.Split("@")[0]);
            App.Pages.ElementsPageLib.TextBoxPage.FillCurrentAddress(currentAddress);
            App.Pages.ElementsPageLib.TextBoxPage.FillPermanentAddress(permanentAddress);
            App.Pages.ElementsPageLib.TextBoxPage.ClickSubmit();
            Thread.Sleep(500); //simply waiting for
            Assert.That(App.Pages.ElementsPageLib.TextBoxPage.IsEmailInputBorderRed);
            App.Pages.ElementsPageLib.TextBoxPage.FillEmail("@" + email.Split("@")[1]);
            App.Pages.ElementsPageLib.TextBoxPage.ClickSubmit();
            var template = "Name:{0}Email:{1}Current Address :{2}Permananet Address :{3}";
            Assert.That(App.Pages.ElementsPageLib.TextBoxPage.GetFinalText() ==
                        string.Format(template, name, email, currentAddress, permanentAddress));
        }
    }
}