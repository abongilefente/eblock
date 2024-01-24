using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation.framework.CoreFuntions.PageObjects.CommonMethods
{
    public class Logout
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Logout(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;
        }
        private By _Logout = By.XPath("//*[@id=\"ctl00_topNavigationAccountSupport_radMenuSupport\"]/ul/li[2]");
        private By _LogoutButton = By.XPath("//span[text()='Logout']");
        public bool LogoutTest()
        {
            bool success = false;
            try
            {
                _wait.Until(drv => _driver.FindElement(_Logout).Displayed);
                _driver.FindElement(_Logout).Click();
                _wait.Until(drv => _driver.FindElement(_LogoutButton).Displayed);
                _driver.FindElement(_LogoutButton).Click();

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;
        }
    }
}
