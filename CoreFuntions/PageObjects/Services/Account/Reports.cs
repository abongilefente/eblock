using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace automation.framework.CoreFuntions.PageObjects.Services.Account
{
    public class Reports
    {
        //Services > Account > Reports > Ivoices 
        private IWebDriver _driver;
        private WebDriverWait _wait;
        
        public Reports _MerchantInvoices;
        public Reports(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;
           
        }
        private By _Reports = By.XPath("//span[text()='Reports']");
        private By _Invoices = By.XPath("//span[text()='Invoices']");

        public bool Invoices()
        {
            bool success = false;
            try
            {
                //_MerchantCommonMethods.ServiceAccountManu();

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;
        }


        //Net Balance

        private By _Service = By.XPath("//span[text()='Services']");
        private By _AccountDropDown = By.XPath("//a[text()='Account']");
        private By _Menu = By.XPath("//div[@id='ctl00_panelButton']");
        private By _ManageAccount = By.XPath("//span[text()='Manage account']");
        public By _Report = By.XPath("//span[text()='Reports']");
        public By _NetAccount = By.XPath("//span[text()='Net balance']");
        public By _Heading = By.XPath("//span[@id='ctl00_ContentPlaceHolder1_lblGridHeaderDescription']");
        public By _CurrentBalance = By.XPath("//a[text()='Current balance']");
        public By _AvailableBalance = By.XPath("//a[text()='Available balance']");

        public bool NetBalanceTest()
        {
            bool success = false;
            try
            {
                _wait.Until(drv => _driver.FindElement(_Service).Displayed);
                _driver.FindElement(_Service).Click();

                _wait.Until(drv => _driver.FindElement(_AccountDropDown).Displayed);
                _driver.FindElement(_AccountDropDown).Click();

                _wait.Until(drv => _driver.FindElement(_Menu).Displayed);
                _driver.FindElement(_Menu).Click();

                _wait.Until(drv => _driver.FindElement(_ManageAccount).Displayed);
                _driver.FindElement(_ManageAccount).Click();

                _wait.Until(drv => _driver.FindElement(_Report).Displayed);
                _driver.FindElement(_Report).Click();

                _wait.Until(drv => _driver.FindElement(_NetAccount).Displayed);
                _driver.FindElement(_NetAccount).Click();

                _wait.Until(drv => _driver.FindElement(_Heading).Displayed);


                _wait.Until(drv => _driver.FindElement(_CurrentBalance).Displayed);
                //_driver.FindElement(_CurrentBalance).Click();

                _wait.Until(drv => _driver.FindElement(_AvailableBalance).Displayed);
                //_driver.FindElement(_AvailableBalance).Click();




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
