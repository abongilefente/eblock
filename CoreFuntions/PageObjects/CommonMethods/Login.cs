using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace automation.framework.CoreFuntions.PageObjects.CommonMethods
{
    public class Login
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Login(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;
        }
        private By _Username = By.XPath("//*[@id='txtUserName']");
        private By _Password = By.XPath("//*[@id='txtPassword']");
        private By _ButtonSubmit = By.XPath("//*[@id='btnSubmit']");
        private By _PIN = By.XPath("//*[@id='txtPIN']");
        private By _AccountNavigation = By.XPath("//a[text()='Accounts']");
        private By _ButtonLogin = By.XPath("//*[@id='btnLogin']");

        //private void 
        public bool LoginTest()
        {
            bool success = false;
            try
            {
                //Enter Username
                _wait.Until(drv => _driver.FindElement(_Username).Displayed);
                _driver.FindElement(_Username).SendKeys("Abongile20 ");
                //Enter Password
                _wait.Until(drv => _driver.FindElement(_Password).Displayed);
                _driver.FindElement(_Password).SendKeys("FeAb3363123");
                //Click login button for the first time
                _wait.Until(drv => _driver.FindElement(_ButtonSubmit).Displayed);
                _driver.FindElement(_ButtonSubmit).Click();

                _wait.Until(drv => _driver.FindElement(_PIN).Displayed);
                _driver.FindElement(_PIN).SendKeys("669664");
                _driver.FindElement(_ButtonLogin).Click();
                _wait.Until(drv => _driver.FindElement(_AccountNavigation).Displayed);

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
