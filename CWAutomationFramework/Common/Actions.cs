using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CWAutomationFramework.Common
{
    public class Actions
    {
        /// <summary>
        /// Clicks on a desired element from the page
        /// </summary>
        public void element_Click(IWebElement element)
        {
            element.Click();
            Console.WriteLine($"Clicking on: {element.GetAttribute("type")}");
        }

        /// <summary>
        /// Sends text to a desired Element on the page
        /// </summary>
        /// <param name="element">Element that the text will be send</param>
        /// <param name="text">The text that you want to send</param>
        public void element_SentText(IWebElement element, string text)
        {
            element.SendKeys(text);
            Console.WriteLine($"Sending text: {text}");
        }

        /// <summary>
        /// Verify that an element is not Active/Enabled
        /// </summary>
        public void element_NotActive(IWebElement element, string elementName)
        {
            Assert.False(element.Enabled, $"Element '{elementName}' is enabled.");
            Console.WriteLine($"Element '{elementName}' is not enabled. Pass.");
        }

        /// <summary>
        /// Verify that an element is Active/Enabled
        /// </summary>
        public void element_Active(IWebElement element, string elementName)
        {
            Assert.IsTrue(element.Enabled, $"Element '{elementName}' is not enabled.");
            Console.WriteLine($"Element '{elementName}' is enabled. Pass.");
        }

        /// <summary>
        /// Verify that an is Displayed
        /// </summary>
        public void element_isDisplayed(IWebElement element, string elementName)
        {
            Assert.IsTrue(element.Displayed, $"Element '{elementName}' is not displayed");
            Console.WriteLine($"Element '{elementName}' is displayed. Pass.");
        }

        /// <summary>
        /// Verify that element text is desired one
        /// </summary>
        public void element_TextIsEqualTo(IWebElement element, string desiredString)
        {
            Assert.AreEqual(desiredString, element.Text, $"Element text does not match. Expected: {desiredString}, actual {element.Text}");
            Console.WriteLine($"Element text '{element.Text}' matches the expected '{desiredString}'. Pass.");
        }

        /// <summary>
        /// Freezes the page so the elements can be loaded
        /// </summary>
        public void wait(int time = 2500)
        {
            Thread.Sleep(time);
            Console.WriteLine($"Pause of: {time} miliseconds.");
        }

        /// <summary>
        /// Assert that the list count is not empty
        /// </summary>
        /// <param name="element">List of elements to count from</param>
        public void element_ListNotEmpty(IList<IWebElement> element)
        {
            Assert.IsTrue(element.Count > 0, "List of elements is empty.");
        }
    }
}
