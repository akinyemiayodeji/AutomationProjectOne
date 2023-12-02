using AutomationProjectOne.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectOne.PageObjects
{
    class LoginPage
    {
        public IWebDriver driver;
        public LoginPage()
        {
            driver = WebHook.driver;
        }
        private By loginButton = By.CssSelector("li[id='menu-item-2940'] a");
        private By emailAddressField = By.CssSelector("input[placeholder='Username/email']");
        private By passwordField = By.CssSelector("#tu-passwordinput");
        private By submitButton = By.CssSelector(".tu-primbtn-lg.tu-user-login");

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }
        public void EnterEmailAddressField()
        {
            driver.FindElement(emailAddressField).Click();
            driver.FindElement(emailAddressField).SendKeys("bukolaakinyemi123@yahoo.com");
        }
        public void EnterPasswordField()
        {
            driver.FindElement(passwordField).Click();
            driver.FindElement(passwordField).SendKeys("12345678");
        }
        public void ClickSumitButton()
        {
            driver.FindElement(submitButton).Click();
        }
        public bool? IAmDirectedToTheProfilePage()
        {
            return driver.Url.Contains("https://qa1.mentorskid.com/profile-settings/?tab=personal_details&useridentity=362");
        }


    }
}