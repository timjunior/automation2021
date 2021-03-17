using Automation_2021.Enums;
using Automation_2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_2021.Tests
{
    [TestFixture]
    public class ContactUsPageTests
    {
        IWebDriver browser;
        HomePage homePage;
        ContactUsPage cPage;
        
        [SetUp]
        public void Setup()
        {
            browser = Browser.Init(BrowserType.Chrome);
            browser.Url = Constants.BaseUrl;
            homePage = new HomePage(browser);           

        }

        [Test]
        public void ValidContuctUsForm()
        {
            
            cPage = homePage
                .ClickOnContactUsLink()
                .SelectSubject("Customer service");
            cPage.EnterEmail("dd@dd.dd");
            cPage.EnterOderRefNumber("sdf315");
            cPage.EnterMessage("My message");
            cPage.ClickOnSendButton();
            Assert.NotNull(cPage.SuccessMessageEl);


        }


        [TearDown]
        public void CleanUp()
        {

        }


      

    }
}
