using AutomationProjectOne.Hooks;
using AutomationProjectOne.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationProjectOne.StepDefinitions
{
    [Binding]
    public class BBCSteps
    {
        public IWebDriver driver = WebHook.driver;
        BbcPage bbcPage = new BbcPage();

        [Given(@"I am on BBC website ""([^""]*)""")]
        public void GivenIAmOnBBCWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I click sports news")]
        public void WhenIClickSportsNews()
        {
            bbcPage.ClickSportsNews();
        }

        [Then(@"Sports news page should display")]
        public void ThenSportsNewsPageShouldDisplay()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(bbcPage.SportsNewsPageShouldDisplay());
        }
    }
}
