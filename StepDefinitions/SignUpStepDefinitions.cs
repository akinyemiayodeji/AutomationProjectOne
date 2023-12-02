using AutomationProjectOne.Hooks;
using AutomationProjectOne.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationProjectOne.StepDefinitions
{
    [Binding]
    class SignUpStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        SignUpPage signUpPage = new SignUpPage();

        [Given(@"I navigate to Mentorskid website")]
        public void GivenINavigateToMentorskidWebsite()
        {
            driver.Navigate().GoToUrl("https://qa1.mentorskid.com/");
        }

        [When(@"I click sign up button")]
        public void WhenIClickSignUpButton()
        {
            signUpPage.ClickSignUpButton();
        }

        [When(@"I enter first name")]
        public void WhenIEnterFirstName()
        {
            signUpPage.ClickFirstNameField();
        }

        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            signUpPage.ClickLastNameField();
        }

        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            Thread.Sleep(5000);
            signUpPage.ClickEmailAddressField();
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            signUpPage.ClickPasswordField();
        }

        [When(@"I click mentee button")]
        public void WhenIClickMenteeButton()
        {
            signUpPage.ClickMenteeButton();
        }

        [When(@"I check terms and conditions")]
        public void WhenICheckTermsAndConditions()
        {
            signUpPage.ClickTermsAndConditions();
        }

        [When(@"I click join now button")]
        public void WhenIClickJoinNowButton()
        {
            signUpPage.ClickJoinNowButton();
        }

        [Then(@"I am directed to profile page")]
        public void ThenIAmDirectedToProfilePage()
        {
            Assert.IsFalse(signUpPage.IAmDirectedToProfilePage());
        }
    }
}
