using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Configuration;

namespace CWAutomationFramework.Common
{
    class LogIn
    {
        private IWebDriver driver;

        public LogIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        #region LoginPage Elements
        //locating the username field, password field and the button , and heading 
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_UsernameTextBox")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_PasswordTextBox")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'ctl00_ContentPlaceHolder1_SubmitButton')]")]
        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@class, 'uitest-menu-my-tasks')]")]
        public IWebElement myTaskHeading { get; set; }
        #endregion

        public void LogginIn(string username = null)
        {
            if (username == null)
            {
                username = ConfigurationManager.AppSettings["username"];
            }

            string password = ConfigurationManager.AppSettings["password"];

            Console.WriteLine($"Login with Username: {username}");
            UserName.SendKeys(username);
            Password.SendKeys(password);
            Console.WriteLine($"Clicking on Login Button\n");
            SignIn.Click();
        }

    }
}
