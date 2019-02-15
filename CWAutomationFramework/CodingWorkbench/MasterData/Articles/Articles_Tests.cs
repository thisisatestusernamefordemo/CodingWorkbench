using CWAutomationFramework.TestBase;
using NUnit.Framework;

namespace CWAutomationFramework.CodingWorkbench.MasterData.Articles
{
    [TestFixture]
    [Category("CodingWorkbench")]
    [Category("Articles")]
    class Articles_Tests : TestBase<Articles_Elements>
    {        
        private const string CONFIG_URL = "url_Coding";
        private const string USERNAME = "giatan";

        public Articles_Tests() : base(CONFIG_URL)
        {

        }

        public override void SetUp()
        {
            base.SetUp();
            element = new Articles_Elements(driver);
        }

        // OneTimeSetUp Create Test Data if needed
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        // OneTimeTearDown clearing up the testData
        public void OneTimeTearDown()
        {

        }


        // GUI test
        [Test]
        public void Articles_GUI()
        {
            action.wait(2500);

            // heading 
            action.element_TextIsEqualTo(element.heading_Article, "Article Search");

            // heading hint
            action.element_isDisplayed(element.heading_Article_Hint, "hint icon");

            // input search
            action.element_isDisplayed(element.input_Article, "input Search");
            action.element_Active(element.input_Article, "input Search");

            action.element_SentText(element.input_Article, "some text");

            action.element_Click(element.btn_Article_Search);

            action.wait(5000);

            // button Search 

            // button Clear Search

            // button Precode New Article

            // button Advance Search

        }

        // Search Test
        [Test]
        public void Articles_Search()
        {
            // press search and wait for results to be displayed
            action.element_Click(element.btn_Article_Search);

            // make sure that the list is not empty
            action.element_ListNotEmpty(element.column_Article_ArticleIds);

            // send text
            string articleId = element.column_Article_ArticleIds[0].Text;
            action.element_SentText(element.input_Article, articleId);

            // press search
            action.element_Click(element.btn_Article_Search);

            // verify the result
            action.element_TextIsEqualTo(element.column_Article_ArticleIds[0], articleId);
        }

        // etc...

    }
}
