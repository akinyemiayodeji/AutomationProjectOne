using AutomationProjectOne.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectOne.PageObjects
{
    class AddingTimeSlotsPage
    {
        public IWebDriver driver;

        public AddingTimeSlotsPage()
        {
            driver = WebHook.driver;
        }
        private By loginbutton = By.CssSelector("li[id='menu-item-2940'] a");
        private By emailAddress = By.CssSelector("input[placeholder='Username/email']");
        private By password = By.CssSelector("#tu-passwordinput");
        private By submitButton = By.CssSelector("a[class='tu-primbtn-lg tu-user-login'] span");
        private By myCalendarButton = By.CssSelector("a[id = 'bookings-tab'] span");
        private By addEditBookingsButton = By.CssSelector(".tu-add-booking-slots.tu-add-appointment");
        private By addNewTimeSlotsButton = By.CssSelector(".tu-newslots.tu-add-appointment-timeslot");
        private By availableServiceDaysField = By.CssSelector("#select2-tu-weekdays-result-57dq-monday");
        private By slotTitleField = By.CssSelector("input[placeholder='Slot title']");
        private By startAndEndTimeDropdown = By.CssSelector("#select2-inter-duration-result-dhlp-5");
        private By breakTimeDropdown = By.CssSelector("#select2-inter-duration-result-e6ey-30");
        private By sectionDurationDropdown = By.CssSelector("#select2-apintment-duration-result-nwc5-15");
        private By customValueBox = By.CssSelector("label[for='appointment-space1']");
        private By generateTimeSlotsButton = By.CssSelector("#tu-generate-timeslots");
        private By saveAndUpdateChangesButton = By.CssSelector("#tu-save-timeslots-btn");
        

        public void ClickLoginButton()
        {
            driver.FindElement(loginbutton).Click();
        }
        public void EnterEmailAddress()
        {
            driver.FindElement(emailAddress).SendKeys("djlakeside2003@yahoo.com");
        }
        public void EnterPassword()
        {
            driver.FindElement(password).SendKeys("Boneup2000#");
        }
        public void ClickSubmitButton()
        {
            driver.FindElement(submitButton).Click();
        }
        public void ClickMyCalendar()
        {
            driver.FindElement(myCalendarButton).Click();
        }
        public void ClickAddEditBookingsButton()
        {
            driver.FindElement(addEditBookingsButton).Click();
        }
        public void ClickAddNewTimeSlotsButton()
        {
            driver.FindElement(addNewTimeSlotsButton).Click();
        }
        public void ClickAvailableServiceDaysField()
        {
            driver.FindElement(availableServiceDaysField).Click();
            driver.FindElement(availableServiceDaysField).Click();
        }
        public void EnterSlotTitleField()
        {
            driver.FindElement(slotTitleField).SendKeys("Automation Training");
        }
        public void EnterStartAndEndDropdown()
        {
            driver.FindElement(startAndEndTimeDropdown).Click();
            driver.FindElement(startAndEndTimeDropdown).Click();
            driver.FindElement(startAndEndTimeDropdown).Click();
            driver.FindElement(startAndEndTimeDropdown).Click();
        }
        public void EnterBreakTimeDropdown()
        {
            driver.FindElement(breakTimeDropdown).Click();
            driver.FindElement(breakTimeDropdown).Click();
        }
        public void EnterSectionDurationDropdown()
        {
            driver.FindElement(sectionDurationDropdown).Click();
            driver.FindElement(sectionDurationDropdown).Click();
        }
        public void ClickCustomValueBox()
        {
            driver.FindElement(customValueBox).Click();
        }
        public void ClickGenerateTimeSlotsButton()
        {
            driver.FindElement(generateTimeSlotsButton).Click();
        }
        public void ClickSaveAndUpdateChangesButton()
        {
            driver.FindElement(saveAndUpdateChangesButton).Click();
        }
        public bool? ThenTimeSlotBookingShouldBeSuccessful()
        {
            return driver.Url.Contains("https://qa1.mentorskid.com/profile-settings/?useridentity=397&tab=bookings");
        }

    }
}
