using Automation_2021.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Automation_2021
{
    public class Browser
    {
        public static IWebDriver Init( BrowserType browserType)
        {
            var driver = GetWebDriver(browserType);
            driver.Manage().Window.Maximize();
            return driver;
        }

        private static IWebDriver GetWebDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeDriver();
                case BrowserType.Firefox:
                    return new FirefoxDriver();
                default:
                    return new ChromeDriver();
            }
        }

        public static void CleanUp(IWebDriver browser)
        {
            if (browser != null)
            {
                browser.Quit();
            }
        }
    }
}
