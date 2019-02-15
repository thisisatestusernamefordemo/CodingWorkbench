using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace CWAutomationFramework.CodingWorkbench.MasterData.Articles
{
    public class Articles_Elements
    {
        private IWebDriver _driver;

        public Articles_Elements(IWebDriver driver)
        {
            _driver = driver;

            // Making shure that the driver will wait 15 seconds to locate an Element.
            // If an element does not appear in the UI for that time the test will fail.
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(25)));
        }

        #region Articles
        // menu button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Articles')]")]
        public IWebElement menu_Article { get; set; }

        // Heading
        [FindsBy(How = How.XPath, Using = "//div[@id='header']")]
        public IWebElement heading_Article { get; set; }

        // Hint
        [FindsBy(How = How.XPath, Using = "//a[@title='Query syntax help']")]
        public IWebElement heading_Article_Hint { get; set; }

        // input field
        [FindsBy(How = How.XPath, Using = "//input[@id='searchfield']")]
        public IWebElement input_Article { get; set; }

        // button Search
        [FindsBy(How = How.XPath, Using = "//i[@class='glyphicon glyphicon-search']")]
        public IWebElement btn_Article_Search { get; set; }

        // button Clear Search
        [FindsBy(How = How.XPath, Using = "//i[@class='glyphicon glyphicon-remove']")]
        public IWebElement btn_Article_ClearSearch { get; set; }

        // button Precode New Article
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/button[1]")]
        public IWebElement btn_Article_PrecodeNewArticle { get; set; }

        // button Advanced Search ( filter ) 
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/div[2]/div[1]/small[1]/a[1]")]
        public IWebElement btn_Article_AdvancedSearch { get; set; }

        // button Advanced Search ( filter ) 
        [FindsBy(How = How.XPath, Using = "//td[contains(@class,'articleId')]")]
        public IList<IWebElement> column_Article_ArticleIds { get; set; }

        #endregion

        #region Articles - Advanced Search

        #endregion

    }
}
