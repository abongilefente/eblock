using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

using RazorEngine.Compilation.ImpromptuInterface;


namespace automation.framework.CoreFuntions
{
    public static class SeleniumSetup
    {
        public static IWebDriver _driver;
        public static ChromeOptions _chromeOptions;
        public static FirefoxOptions _firefoxOptions;
        public static void Init(string browser)
        {
            if (string.IsNullOrEmpty(browser))
                browser = "default";

            switch (browser)
            {
                case "FireFox":
                    
                    break;
                case "Safari":
                    _chromeOptions = new ChromeOptions();
                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                    // _chromeOptions.AddArguments("headless");
                    break;

                default:
                    _chromeOptions = new ChromeOptions();
                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                    break;
            }

        }
        public static void NavigatetoURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
        public static void QuitBrowser()
        {
            _driver.Close();
        }
    }
}
