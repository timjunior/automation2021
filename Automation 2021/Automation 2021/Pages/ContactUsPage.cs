using OpenQA.Selenium;

namespace Automation_2021.Pages
{
    public class ContactUsPage
    {
        private readonly IWebDriver _browser;

        public string Title = "Contact us - My Store";

        public ContactUsPage(IWebDriver browser)
        {
            _browser = browser;
        }



    }
}
