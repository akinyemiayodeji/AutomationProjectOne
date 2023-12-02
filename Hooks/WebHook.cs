﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationProjectOne.Hooks
{
    [Binding]
    public class WebHook
    {

        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }


        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Close();


        }
    }
}