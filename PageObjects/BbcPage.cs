using AutomationProjectOne.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectOne.PageObjects
{
    public class BbcPage
    {
        public IWebDriver driver;
        public BbcPage()
        {
            driver = WebHook.driver;
        }
        private By Sports = By.XPath("//*[@id=\"orb-header\"]/div/nav[1]/ul/li[3]/a/span");
        public void ClickSportsNews()
        {
            driver.FindElement(Sports).Click();  
        }

        public bool? SportsNewsPageShouldDisplay()
        {
            return driver.Url.Contains("https://www.bbc.co.uk/sport");
        }
    }
}
