using OpenQA.Selenium;

namespace Automation_2021.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _browser;
        public string Title => _browser.Title;

        public HomePage(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebElement ContactUsLink => _browser.FindElement(By.LinkText("Contact us"));

        public ContactUsPage ClickOnContactUsLink()
        {
            ContactUsLink.Click();
            return new ContactUsPage(_browser);
        }
    }
}
