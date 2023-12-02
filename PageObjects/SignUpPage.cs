using AutomationProjectOne.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectOne.PageObjects
{
    class SignUpPage
    {
        public IWebDriver driver;

        public SignUpPage()
        {
            driver = WebHook.driver;
        }
        private By signUpButton = By.CssSelector("a[href='https://qa1.mentorskid.com/signup/']");
        private By firstNameField = By.CssSelector("input[placeholder='First name']");
        private By lastNameField = By.CssSelector("input[placeholder='Last name']");
        private By emailAddressField = By.CssSelector("input[placeholder='Enter your email address']");
        private By passwordField = By.CssSelector("#tu-passwordinput");
        private By menteeButton = By.CssSelector("label[for='user_type_student']");
        private By termsAndConditionButton = By.CssSelector("label[for='tu-terms']");
        private By joinNowButton = By.CssSelector("a[class='tu-primbtn-lg tu-submit-registration'] span");

        public void ClickSignUpButton()
        {
            driver.FindElement(signUpButton).Click();
        }
        public void ClickFirstNameField()
        {
            driver.FindElement(firstNameField).Click();
            driver.FindElement(firstNameField).Clear();
            driver.FindElement(firstNameField).SendKeys("Ayodeji");
        }
        public void ClickLastNameField()
        {
            driver.FindElement(lastNameField).Click();
            driver.FindElement(lastNameField).Clear();
            driver.FindElement(lastNameField).SendKeys("Akinyemi");
        }
        public void ClickEmailAddressField()
        {
           // driver.FindElement(emailAddressField).Click();
           // driver.FindElement(emailAddressField).Clear();
           // driver.FindElement(emailAddressField).SendKeys("jasperakinyemi1112@gmail.com");

            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            driver.FindElement(emailAddressField).SendKeys("jasperakinyemi" + randomInt + "@gmail.com");
        }
        public void ClickPasswordField()
        {
            driver.FindElement(passwordField).Click();
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys("Boneup2000#");
        }
        public void ClickMenteeButton()
        {
            driver.FindElement(menteeButton).Click();
        }
        public void ClickTermsAndConditions()
        {
            driver.FindElement(termsAndConditionButton).Click();
        }
        public void ClickJoinNowButton()
        {
            driver.FindElement(joinNowButton).Click();
        }

        public bool? IAmDirectedToProfilePage()
        {
            return driver.Url.Contains("https://qa1.mentorskid.com/profile-settings/?tab=personal_details#038;useridentity=405");
        }
    }
}