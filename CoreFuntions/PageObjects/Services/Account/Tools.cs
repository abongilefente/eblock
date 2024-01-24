using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using automation.framework.CoreFuntions.PageObjects.CommonMethods;

namespace automation.framework.CoreFuntions.PageObjects.Services.Account
{
    internal class Tools

    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        
        public Tools(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;
           
        }
        private void WaitClick(By Xpath)
        {
            _wait.Until(drv => _driver.FindElement(Xpath).Displayed);
            _driver.FindElement(Xpath).Click();
        }

        // Account Number TipsTest
        private By _Tools = By.XPath("//span[text()='Tools']");
        private By _AccountNumberTips = By.XPath("//span[text()='Account number tips']");
        public By _Heading = By.XPath("//span[@id='ctl00_ContentPlaceHolder1_lblh2']");
        public By _Bank = By.XPath("//th[text()='Bank ']");
        public By _Tips = By.XPath("//th[text()='Tip ']");
        public bool AccountNumberTipsTest()
        {
            bool success = false;
            try
            {
                //Services > Account> Menu              
                _wait.Until(drv => _driver.FindElement(_Tools).Displayed);
                _driver.FindElement(_Tools).Click();
                //Click Account Number tips                
                WaitClick(_AccountNumberTips);
                //Check column headings 
                WaitClick(_Bank);

                success = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;

        }

        //Validate ID 
        //private By _Tools = By.XPath("//span[text()='Tools']");
        //private By _Heading = By.XPath("//span[@id='ctl00_ContentPlaceHolder1_lblh2']");
        private By _ValidateIDnumber = By.XPath("//span[text()='Validate ID number']");
        private By _IdentityNumber = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtIdentityNumber']");
        private By _Submit = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnAdd']");

        public bool ValidateID()
        {
            bool success = false;
            try
            {
                //Use internal Dev account 
                //_MerchantCommonMethods.InternalDev();
                //Services > Account> Menu 
                // _MerchantCommonMethods.ServiceAccountManu();
                //Click Tools                
                WaitClick(_Tools);
                //Click Validate ID number 
                WaitClick(_ValidateIDnumber);
                //Check Heading 
                _wait.Until(drv => _driver.FindElement(_Heading).Displayed);
                //Enter ID number and submit 
                _wait.Until(drv => _driver.FindElement(_IdentityNumber).Displayed);
                _driver.FindElement(_IdentityNumber).SendKeys("9203276364081");
                _wait.Until(drv => _driver.FindElement(_Submit).Displayed);
                _driver.FindElement(_Submit).Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));

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
