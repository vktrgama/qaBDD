using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using TechTalk.SpecFlow;

namespace qaBDD
{
    [Binding]
    public class TestMyHomePageSteps
    {
        [Given(@"I am on the home page of quiniela")]
        public void GivenIAmOnTheHomePageOfQuiniela()
        {
           var _driver = new PhantomJSDriver();
            _driver.Navigate().GoToUrl("http://www.vgama.com/laquiniela");

            Assert.That(_driver.Title == "La Quiniela 2014");
            _driver.Quit();

        }

        [Given(@"page is all rederdered")]
        public void GivenPageIsAllRederdered()
        {
            var _driver = new PhantomJSDriver();
            _driver.Navigate().GoToUrl("http://www.vgama.com/laquiniela");

            Assert.That(_driver.Title == "La Quiniela 2014");
            _driver.Quit();
        }

        [When(@"Look for the registration form")]
        public void WhenLookForTheRegistrationForm()
        {
            var _driver = new PhantomJSDriver();
            _driver.Navigate().GoToUrl("http://www.vgama.com/laquiniela");

            Assert.That(_driver.Title == "La Quiniela 2014");
            _driver.Quit();
        }

        [Then(@"I should be able to enter my email")]
        public void ThenIShouldBeAbleToEnterMyEmail()
        {
            var _driver = new PhantomJSDriver();
            _driver.Navigate().GoToUrl("http://www.vgama.com/laquiniela");

            Assert.That(_driver.Title == "La Quiniela 2014");
            _driver.Quit();
        }
    }
}
