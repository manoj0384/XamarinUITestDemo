using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace xamarinFormApp.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //[Test]
        //public void WelcomeTextIsDisplayed()
        //{
        //    AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
        //    app.Screenshot("Welcome screen.");

        //    Assert.IsTrue(results.Any());
        //}

        [Test]
        public void NumbersCanBeAdded()
        {
            app.Screenshot("Welcome screen.");
            app.WaitForElement(c => c.Marked("BtnClr"));
            app.Tap(c=>c.Marked("BtnClr"));
            app.Screenshot("Fields cleared.");
            app.EnterText(c => c.Marked("Num1"), "3");
            app.DismissKeyboard();
            app.EnterText(c => c.Marked("Num2"), "3");
            app.DismissKeyboard();
            app.Tap(c => c.Marked("BtnAdd"));
            app.Screenshot("Numbers Added.");
            AppResult[] results = app.Query(c => c.Marked("Result"));
            var expectedValue = "6";
            Assert.True(expectedValue == results[0].Text, $"Expected {expectedValue} but actual is {results[0].Text}");
        }

        [Test]
        public void NumbersCanBeSubtracted()
        {
            app.Screenshot("Welcome screen.");
            app.WaitForElement(c => c.Marked("BtnClr"));
            app.Tap(c => c.Marked("BtnClr"));
            app.Screenshot("Fields cleared.");
            app.EnterText(c => c.Marked("Num1"), "6");
            app.DismissKeyboard();
            app.EnterText(c => c.Marked("Num2"), "3");
            app.DismissKeyboard();
            app.Tap(c => c.Marked("BtnSub"));
            app.Screenshot("Numbers Subtracted.");
            AppResult[] results = app.Query(c => c.Marked("Result"));
            var expectedValue = "3";
            Assert.True(expectedValue == results[0].Text, $"Expected {expectedValue} but actual is {results[0].Text}");
        }

        [Test]
        public void NumbersCanBeMultiplied()
        {
            app.Screenshot("Welcome screen.");
            app.WaitForElement(c => c.Marked("BtnClr"));
            app.Tap(c => c.Marked("BtnClr"));
            app.Screenshot("Fields cleared.");
            app.EnterText(c => c.Marked("Num1"), "6");
            app.DismissKeyboard();
            app.EnterText(c => c.Marked("Num2"), "3");
            app.DismissKeyboard();
            app.Tap(c => c.Marked("BtnMul"));
            app.Screenshot("Numbers Multiplied.");
            AppResult[] results = app.Query(c => c.Marked("Result"));
            var expectedValue = "18";
            Assert.True(expectedValue == results[0].Text, $"Expected {expectedValue} but actual is {results[0].Text}");
        }

        [Test]
        public void NumbersCanBeDivided()
        {
            app.Screenshot("Welcome screen.");
            app.WaitForElement(c => c.Marked("BtnClr"));
            app.Tap(c => c.Marked("BtnClr"));
            app.Screenshot("Fields cleared.");
            app.EnterText(c => c.Marked("Num1"), "6");
            app.DismissKeyboard();
            app.EnterText(c => c.Marked("Num2"), "3");
            app.DismissKeyboard();
            app.Tap(c => c.Marked("BtnDiv"));
            app.Screenshot("Numbers Divided.");
            AppResult[] results = app.Query(c => c.Marked("Result"));
            var expectedValue = "2";
            Assert.True(expectedValue == results[0].Text, $"Expected {expectedValue} but actual is {results[0].Text}");
        }

        [Test]
        public void RemainderCanBeCalculated()
        {
            app.Screenshot("Welcome screen.");
            app.WaitForElement(c => c.Marked("BtnClr"));
            app.Tap(c => c.Marked("BtnClr"));
            app.Screenshot("Fields cleared.");
            app.EnterText(c => c.Marked("Num1"), "6");
            app.DismissKeyboard();
            app.EnterText(c => c.Marked("Num2"), "3");
            app.DismissKeyboard();
            app.Tap(c => c.Marked("BtnRem"));
            app.Screenshot("Remainder Calculated.");
            AppResult[] results = app.Query(c => c.Marked("Result"));
            var expectedValue = "0";
            Assert.True(expectedValue == results[0].Text, $"Expected {expectedValue} but actual is {results[0].Text}");
        }
    }
}
