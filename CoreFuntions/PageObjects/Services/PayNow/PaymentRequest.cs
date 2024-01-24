using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automation.framework.CoreFuntions.PageObjects.Services.Account;
using System.IO;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;

namespace automation.framework.CoreFuntions.PageObjects.Services.PayNow
{
    public class PaymentRequest
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public PaymentRequest(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;
        }
        //Method to wait and click a page object
        private void WaitClick(By Xpath)
        {
            _wait.Until(drv => _driver.FindElement(Xpath).Displayed);
            _driver.FindElement(Xpath).Click();
        }
        private void Wait(int time)
        {
            Thread.Sleep(time);
        }

        private void WaitSendKeys(By Xpath,String Input)
        {
            _wait.Until(drv => _driver.FindElement(Xpath).Displayed);
            _driver.FindElement(Xpath).SendKeys(Input);
        }
        //Service > Paynow > Menu
        private By ServiceNav = By.XPath("//span[text()='Services']");
        private By PayNowDropDown = By.XPath("//a[text()='Pay Now']");
        private By MenuHarmburger = By.XPath("//div[@id='ctl00_panelButton']");
        private void ServicePaynowManage()
        {
            //Click Service
            WaitClick(ServiceNav);
            //Click Account on the Dropdown
            WaitClick(PayNowDropDown);
            //Click Menu 
            WaitClick(MenuHarmburger);
        }
        /**************** Payment Request ***************************/
        private By PayementRequest = By.XPath("//span[text()='Payment request']");
        private By CreateB = By.XPath("//span[text()='Create']");
        private By YourReference = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtP2']");
        private By Amount = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtAmount']");
        private By type = By.XPath("//select[@id='ctl00_ContentPlaceHolder1_ddlPaymentType']");
        private By Email = By.XPath("//option[text()='Email']");
        private By Description = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtP3']");
        private By EmailAddress = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtM9']");
        private By Send = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnInsert']");

        private By SMS = By.XPath("//option[text()='SMS']");
        private By MobileNumber = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtM11']");

        private By SMS_Email = By.XPath("//option[text()='SMS & Email']");

        private By Whatsapp = By.XPath("//option[text()='WhatsApp']");

        private By QRCode = By.XPath("//option[text()='QR code']");





        public bool Create(String typeD)
        {
            bool success = false;
            switch (typeD)
            {
                
                case "Email":
                    try
                    {
                        ServicePaynowManage();
                        WaitClick(PayementRequest);
                        WaitClick(CreateB);
                        WaitClick(type);
                        WaitClick(Email);
                        Wait(1000);
                        WaitSendKeys(YourReference, "Reference");
                        Wait(1000);
                        _driver.FindElement(Amount).Clear();
                        Wait(500);
                        WaitSendKeys(Amount, "0.02");
                        WaitSendKeys(Description, "Authomated Testing " + DateTime.Now.ToString(" dd MMM yyyy hh_mm tt"));
                        Wait(500);
                        WaitSendKeys(EmailAddress, "abongile.fente@netcash.co.za");
                        //Sven.Woxholt@netcash.co.za , stephen.ogorman@netcash.co.za
                        Wait(1000);
                        WaitClick(Send);
                        Wait(5000);
                        success = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Error Message: {0}", e.Message));
                    }
                    break;
                case "SMS":
                    try
                    {
                        ServicePaynowManage();
                        WaitClick(PayementRequest);
                        WaitClick(CreateB);
                        WaitClick(type);
                        WaitClick(SMS);
                        Wait(500);
                        WaitSendKeys(YourReference, "Reference");
                        Wait(500);
                        _driver.FindElement(Amount).Clear();
                        Wait(500);
                        WaitSendKeys(Amount, "0.02");
                        WaitSendKeys(Description, "Authomated Testing");
                        Wait(500);
                        _driver.FindElement(MobileNumber).Clear();
                        Wait(500);
                        WaitSendKeys(MobileNumber, "00747074065"); //27827740569
                        Wait(500);
                        WaitClick(Send);
                        Wait(2000);
                        success = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Error Message: {0}", e.Message));
                    }

                    break;
                case "SMS & Email":
                    try
                    {
                        ServicePaynowManage();
                        WaitClick(PayementRequest);
                        WaitClick(CreateB);
                        WaitClick(type);                       
                        WaitClick(SMS_Email);
                        Wait(1000);
                        WaitSendKeys(YourReference, "Reference");
                        Wait(2000);
                        _driver.FindElement(Amount).Clear();
                        Wait(1000);
                        WaitSendKeys(Amount, "0.02");
                        WaitSendKeys(Description, "Authomated Testing");
                        WaitSendKeys(MobileNumber, "00747074065");
                        Wait(1000);
                     
                        WaitSendKeys(EmailAddress, "abongile.fente@netcash.co.za");
                        //Sven.Woxholt@netcash.co.za , stephen.ogorman@netcash.co.za
                        Wait(1000);
                        WaitClick(Send);
                        Wait(5000);
                        success = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Error Message: {0}", e.Message));
                    }
                    break;
                case "Whatsapp":
                    try
                    {
                        ServicePaynowManage();
                        WaitClick(PayementRequest);
                        WaitClick(CreateB);
                        WaitClick(type);
                        WaitClick(Whatsapp);
                        Wait(1000);
                        WaitSendKeys(YourReference, "Reference");
                        Wait(1000);
                        _driver.FindElement(Amount).Clear();
                        Wait(1000);
                        WaitSendKeys(Amount, "0.02");
                        WaitSendKeys(Description, "Authomated Testing");
                        Wait(1000);
                        WaitSendKeys(MobileNumber, "0747074065");
                        //Sven.Woxholt@netcash.co.za , stephen.ogorman@netcash.co.za
                        Wait(1000);
                        WaitClick(Send);
                        Wait(5000);
                        success = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Error Message: {0}", e.Message));
                    }
                    break;
                case "QR code":
                    try
                    {
                        ServicePaynowManage();
                        WaitClick(PayementRequest);
                        WaitClick(CreateB);
                        WaitClick(type);
                        WaitClick(QRCode);
                        Wait(1000);
                        WaitSendKeys(YourReference, "Reference");
                        Wait(1000);
                        _driver.FindElement(Amount).Clear();
                        Wait(1000);
                        WaitSendKeys(Amount, "0.02");
                        WaitSendKeys(Description, "Authomated Testing");
                        Wait(1000);
                        WaitClick(Send);


                        success = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(string.Format("Error Message: {0}", e.Message));
                    }
                    break;
            }            
            return success;
        }
        /**Method to resnd payment reqyest**/
        private By resend = By.XPath("//span[text()='Resend']");
        private By from = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_radDateFrom_dateInput']");
        private By to = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_radDateTo_dateInput']");
        private By Select = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnSearch']");
        private By ResendB = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_grdvAccountPaynowResend_ctl03_btnResend']");
        private By MobileNumber1 = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_txtM11']");
        private By Send1 = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_btnInsert']");
        private By SendToMobile = By.XPath("//input[@id='ctl00_ContentPlaceHolder1_cbxM12']");
        

        public bool Resend()
        {
            bool success = false;
            try
            {
                //Services > Paynow > Menu 
                ServicePaynowManage();
                WaitClick(PayementRequest);
                WaitClick(resend);
                WaitSendKeys(from, "2023-10-02");
                WaitSendKeys(to, "2023-10-31");
                WaitClick(Select);
                WaitClick(ResendB);

                WaitClick(SendToMobile);            
                Wait(1000);
                WaitSendKeys(MobileNumber1, "00747074065");
                Wait(2000);
                WaitClick(Send1);
                Wait(0500);
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
