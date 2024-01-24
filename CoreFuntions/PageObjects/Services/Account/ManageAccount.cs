using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace automation.framework.CoreFuntions.PageObjects.Services.Account
{
    public class ManageAccount
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public ManageAccount(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;

        }
        //Method to wait and click
        private void WaitClick(By Xpath)
        {
            _wait.Until(drv => _driver.FindElement(Xpath).Displayed);
            _driver.FindElement(Xpath).Click();
        }
        

        //Service > Account > Menu
        private By ServiceNav = By.XPath("//span[text()='Services']");
        private By AccountDropDown = By.XPath("//a[text()='Account']");
        private By MenuHarmburger = By.XPath("//div[@id='ctl00_panelButton']");
        private void ServiceAccountManage()
        {
            //Click Service
            WaitClick(ServiceNav);
            //Click Account on the Dropdown
            WaitClick(AccountDropDown);
            //Click Menu 
            WaitClick(MenuHarmburger);
        }



        /******************* MANAGE ACCOUNT ********************/

        /*****  INSTANT FUNDING | Services > Account > Manage Account *****/
       
        private By _ManageAccount = By.XPath("//span[text()='Manage account']");
        private By InstantFundingMenuItem = By.XPath("//span[text()='Instant funding']");
        public bool InstantFunding()
        {
            bool success = false;
            try
            {
                ServiceAccountManage();
                //Manage Account 
                WaitClick(_ManageAccount);
                //Instant Funding
                WaitClick(InstantFundingMenuItem);
                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;
        }

        /*****  INTER ACCOUNT TRANSFER  | Services > Account > Manage Account *****/
        private By Inter_AccountTrasnfer = By.XPath("//span[text()='Inter-account transfer']");
        public bool InterAccountTransfer()
        {
            bool success = false;
            try
            {
                ServiceAccountManage();
                //Manage Account 
                WaitClick(_ManageAccount);
                //Inter_AccountTrasnfer
                WaitClick(Inter_AccountTrasnfer);

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;
        }

        /*****  Netcash ACCOUNT TRANSFER  | Services > Account > Manage Account *****/
        private By NetcashAccountTransferItem = By.XPath("//span[text()='Netcash account transfer']");
        public bool NetcashAccountTransfer()
        {
            bool success = false;
            try
            {
                ServiceAccountManage();
                //Manage Account 
                WaitClick(_ManageAccount);
                //NetcashAccountTransfer
                WaitClick(NetcashAccountTransferItem);

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;
        }


        /*****  Netcash ACCOUNT TRANSFER  | Services > Account > Manage Account *****/
        private By NetcashClearingAccountsItem = By.XPath("//span[text()='Netcash clearing accounts']");
        private By NetcashClearingAccountsDropdown = By.XPath("//select[@id='ctl00_ContentPlaceHolder1_ddlClearingAccount']");
        private By ABSA = By.XPath("//option[text()=\"ABSA Clearing Account\"]");
        public bool NetcashClearingAccounts()
        {
            bool success = false;
            try
            {
                ServiceAccountManage();
                //Manage Account 
                WaitClick(_ManageAccount);
                //NetcashAccountTransfer
                WaitClick(NetcashClearingAccountsItem);
                WaitClick(NetcashClearingAccountsDropdown);
                WaitClick(ABSA);
                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;
        }

        /**********************************ReleaseFundHistory*******************************/

        
        private By _ReleaseFundHistory = By.XPath("//span[text()='Release funds history']");
        private By _FromDate = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtStartDate']");
        private By _ToDate = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtEndDate']");
        private By _Submit = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnSelect']");
        private By _Download = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnDownload']");

        public bool ReleaseFundHistory()
        {
            bool success = false;
            try
            {
                ServiceAccountManage();
                //Click Manage Account 
                WaitClick(_ManageAccount);
                //Click Request funds Hostory
                WaitClick(_ReleaseFundHistory);
                //Enter date
                _wait.Until(drv => _driver.FindElement(_FromDate).Displayed);
                _wait.Until(drv => _driver.FindElement(_ToDate).Displayed);
                //_driver.FindElement(_FromDate).SendKeys("2023-05-24");

                WaitClick(_Submit);
                WaitClick(_Download);


                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Error Message: {0}", e.Message));
            }
            return success;
        }

        /**********************************Request Release Funds *******************************/

        // private By _ManageAccount = By.XPath("//span[text()='Manage account']");
        public By _RequestReleaseFunds = By.XPath("//span[text()='Request release funds']");
        private By _DateFrom = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtStartDate']");
        private By _DateEnd = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtEndDate']");
        // private By _Submit = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnSelect']");
        private By _ReleaseFunds = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnFundsReleaseNew']");

        private By _ReleaseDate = By.XPath("//a[text()='Release date']");
        private By _RequestAmount = By.XPath("//a[text()='Requested amount']");
        private By _PayAll = By.XPath("//a[text()='Pay All']");
        private By _ChangedBy = By.XPath("//a[text()='Changed by']");
        private By _ChangedOn = By.XPath("//a[text()='Changed on']");
        private By _Paid = By.XPath("//a[text()='Paid']");
        private By _UnpaidReason = By.XPath("//a[text()='Unpaid Reason']");

        public bool RequestReleaseFundsTest()
        {
            bool success = false;
            try
            {
                //Services > Account> Menu 
                ServiceAccountManage();
                //Click Manage Account 
                WaitClick(_ManageAccount);
                //Click Request release funds 
                WaitClick(_RequestReleaseFunds);
                //Submit 
                WaitClick(_Submit);
                /*Validate headings
                _wait.Until(drv => _driver.FindElement(_ReleaseDate).Displayed);
                _wait.Until(drv => _driver.FindElement(_RequestAmount).Displayed);
                _wait.Until(drv => _driver.FindElement(_PayAll).Displayed);
                _wait.Until(drv => _driver.FindElement(_ChangedBy).Displayed);
                _wait.Until(drv => _driver.FindElement(_ChangedOn).Displayed);
                _wait.Until(drv => _driver.FindElement(_Paid).Displayed);
                _wait.Until(drv => _driver.FindElement(_UnpaidReason).Displayed); */

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
