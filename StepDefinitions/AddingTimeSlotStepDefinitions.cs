using AutomationProjectOne.Hooks;
using AutomationProjectOne.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationProjectOne.StepDefinitions
{
    [Binding]
    class AddingTimeSlotStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        AddingTimeSlotsPage addingTimeSlotsPage = new AddingTimeSlotsPage();

        [Given(@"I navigate to Mentorskid website as a Mentor")]
        public void GivenINavigateToMentorskidWebsiteAsAMentor()
        {
            driver.Navigate().GoToUrl("https://qa1.mentorskid.com/");
        }

        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            addingTimeSlotsPage.ClickLoginButton();
        }

        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            addingTimeSlotsPage.EnterEmailAddress();
        }

        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            addingTimeSlotsPage.EnterPassword();
        }

        [Given(@"I click submit button")]
        public void GivenIClickSubmitButton()
        {
            addingTimeSlotsPage.ClickSubmitButton();
        }

        [Given(@"I click my calendar button")]
        public void GivenIClickMyCalendarButton()
        {
            addingTimeSlotsPage.ClickMyCalendar();
        }

        [Given(@"I click add/Edit bookings button")]
        public void GivenIClickAddEditBookingsButton()
        {
            addingTimeSlotsPage.ClickAddEditBookingsButton();
        }

        [Given(@"I click add new time slots button")]
        public void GivenIClickAddNewTimeSlotsButton()
        {
            addingTimeSlotsPage.ClickAddNewTimeSlotsButton();
        }

        [Given(@"I select available service days")]
        public void GivenISelectAvailableServiceDays()
        {
            addingTimeSlotsPage.ClickAvailableServiceDaysField();
        }

        [Given(@"I enter slot title field")]
        public void GivenIEnterSlotTitleField()
        {
            addingTimeSlotsPage.ClickSubmitButton();
        }

        [Given(@"I select start and end time from dropdown")]
        public void GivenISelectStartAndEndTimeFromDropdown()
        {
            addingTimeSlotsPage.EnterStartAndEndDropdown();
        }

        [Given(@"I select break time from dropdown")]
        public void GivenISelectBreakTimeFromDropdown()
        {
            addingTimeSlotsPage.EnterBreakTimeDropdown();
        }

        [Given(@"I select session duration from dropdown")]
        public void GivenISelectSessionDurationFromDropdown()
        {
            addingTimeSlotsPage.EnterSectionDurationDropdown();
        }

        [Given(@"I check custom value box")]
        public void GivenICheckCustomValueBox()
        {
            addingTimeSlotsPage.ClickCustomValueBox();
        }

        [When(@"I click Generate time slots button")]
        public void WhenIClickGenerateTimeSlotsButton()
        {
            addingTimeSlotsPage.ClickGenerateTimeSlotsButton();
        }

        [When(@"I click save & update changes button")]
        public void WhenIClickSaveUpdateChangesButton()
        {
            addingTimeSlotsPage.ClickSaveAndUpdateChangesButton();
        }

        [Then(@"Time slot booking should be successful")]
        public void ThenTimeSlotBookingShouldBeSuccessful()
        {
            Assert.IsFalse(addingTimeSlotsPage.ThenTimeSlotBookingShouldBeSuccessful());
        }

    }
}
