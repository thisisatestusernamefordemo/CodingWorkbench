using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using CWAutomationFramework.Common;

namespace CWAutomationFramework.TestBase
{
    public class TestBase<TElements>
    {
        private string CONFIG_URL;
        private string USERNAME;

        public TestBase(string configUrlName, string notDefaultUser = null)
        {
            CONFIG_URL = configUrlName;
            USERNAME = notDefaultUser;
        }

        
        public IWebDriver driver { get; set; }
        
        public TElements element { get; set; }

        public Actions action { get; set; }


        [SetUp]
        public virtual void SetUp()
        {
            // Getting the URL from the AppConfig
            string Url = ConfigurationManager.AppSettings[CONFIG_URL];

            // Calling the ChromeDriver
            driver = new ChromeDriver();
            Console.WriteLine("Starting Browser.");

            // Making the Driver to maximize the window.
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximizing the browser window.");

            // Navigating to the desired URL from the AppConfig
            driver.Navigate().GoToUrl(Url);
            Console.WriteLine($"Navigating to '{Url}'.\n");

            // Calling the LogIn class
            LogIn log = new LogIn(driver);

            // Performing the Login 
            log.LogginIn(USERNAME);

            // Calling the Functions class  
            action = new Actions();
        }

        [TearDown]
        public virtual void TearDown()
        {
            // Calling the LogOut class
            LogOut logOut = new LogOut(driver);
            Console.WriteLine("\nLogging out.");

            // Performing the LogOut
            logOut.LogginOut();

            // Clossing the Driver
            Console.WriteLine("Closing the driver.");
            driver.Close();

            // Quiting the Driver
            Console.WriteLine("Quiting the driver.");
            driver.Quit();
        }

    }
}
