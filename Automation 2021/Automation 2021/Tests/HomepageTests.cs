using Automation_2021.Enums;
using Automation_2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Automation_2021
{

    [TestFixture]
    public class HomepageTests
    {
        IWebDriver browser;
        HomePage homePage;

        [SetUp]
        public void Initilize()
        {
            browser = Browser.Init(BrowserType.Chrome);
            browser.Url = Constants.BaseUrl;
            homePage = new HomePage(browser);
        }

        [Test]
        public void Verify_Homepage_Title()
        {
            Assert.AreEqual(
                 browser.Title,
                 homePage.Title
                );
        }

        [Test]
        public void It_Should_Navigate_To_ContactUs_Page()
        {
            var contactUsPage =
                homePage
                    .ClickOnContactUsLink();
            Assert.AreEqual(
                browser.Title, 
                contactUsPage.Title);
        }

        [TearDown]
        public void CleanUp()
        {
            Browser.CleanUp(browser);
        }
    }
}
