using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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


        #region Elements
        public IWebElement WarningMessageEl => _browser.FindElement(By.XPath("//p[@class='There is 1 error']"));
        public IWebElement SuccessMessageEl => _browser.FindElement(By.XPath("//p[@class='alert alert-success']"));
        public IWebElement SendButton => _browser.FindElement(By.Id("submitMessage"));
        public IWebElement EmailAddressField => _browser.FindElement(By.Id("email"));
        public IWebElement OrderRefField => _browser.FindElement(By.Id("id_order"));
        public IWebElement SubjectHeadingDropdown => _browser.FindElement(By.Id("id_contact"));
        public IWebElement MessageBox => _browser.FindElement(By.Name("message"));
        #endregion


        #region Page actions

        public void EnterEmail(string email)
        {
            EmailAddressField.SendKeys(email);
        }

        public void EnterOderRefNumber(string refNum)
        {
            OrderRefField.SendKeys(refNum);
        }

        public void EnterMessage(string message)
        {
            MessageBox.SendKeys(message);
        }

        public ContactUsPage SelectSubject(string sub)
        {
            //e.g."Customer service"

            //handling select class

            var subHeadingSelect = new SelectElement(SubjectHeadingDropdown);
            subHeadingSelect.SelectByText(sub);
            return this;
        }

        public void ClickOnSendButton()
        {
            SendButton.Click();
        }


        #endregion
    }
}
