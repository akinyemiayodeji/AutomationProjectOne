using AutomationProjectOne.Hooks;
using AutomationProjectOne.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationProjectOne.StepDefinitions
{
    [Binding]
    class LoginStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        LoginPage loginPage = new LoginPage();

        [Given(@"I navigate to the Mentorskid website")]
        public void GivenINavigateToTheMentorskidWebsite()
        {
            driver.Navigate().GoToUrl("https://qa1.mentorskid.com/");
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            loginPage.EnterEmailAddressField();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            loginPage.EnterPasswordField();
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            loginPage.ClickSumitButton();
        }

        [Then(@"I am directed to the profile page")]
        public void ThenIAmDirectedToTheProfilePage()
        {
            Assert.IsFalse(loginPage.IAmDirectedToTheProfilePage());
        }
    }
}
