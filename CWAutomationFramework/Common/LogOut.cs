using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace CWAutomationFramework.Common
{
    class LogOut
    {

        private IWebDriver driver;

        public LogOut(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        //Locating log out button - NCode
        [FindsBy(How = How.XPath, Using = "//a[@id='logout-link']")]
        IWebElement btn_LogOut { get; set; }

        public void LogginOut()
        {
            Assert.IsTrue(btn_LogOut.Displayed, "Button Log Out is not displayed.");
            btn_LogOut.Click();
        }

    }
}
