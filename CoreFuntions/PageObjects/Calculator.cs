using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace automation.framework.CoreFuntions.PageObjects
{
    public class Calculator
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Calculator(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;
        }
        private By Number = By.XPath("//span[text()='4']");        
        private By Number2 = By.XPath("//span[text()='2']");
        private By Add = By.XPath("//span[text()='+']");
        private By Minus = By.XPath("//span[text()='–']");
        private By Multiply = By.XPath(" //span[text()='×']");
        private By Devide = By.XPath("//span[text()='/']");
        private By EqualTo = By.XPath("//span[text()='=']");
        private By EC = By.XPath("//span[text()='AC']");
        

        private void WaitClick(By Xpath)
        {
            _wait.Until(drv => _driver.FindElement(Xpath).Displayed);
            _driver.FindElement(Xpath).Click();
        }
        private void Wait(By Xpath)
        {
            _wait.Until(drv => _driver.FindElement(Xpath).Displayed);

        }
        //subtraction ,division, CE functionalities
        public bool Calculationsr(String methods)
        {
            bool success = false;
            try
            {
                switch (methods)
                {
                    case "subtraction":
                        //Click the number to work with 
                        WaitClick(Number);
                        //Click sign(+,-,x,/)
                        WaitClick(Minus);
                        //Click the number to work with 
                        WaitClick(Number2);
                        //Get the answer 
                        WaitClick(EqualTo);
                        break;
                    case "division":
                        //Click the number to work with 
                        WaitClick(Number);
                        //Click sign(+,-,x,/)
                        WaitClick(Devide);
                        //Click the number to work with 
                        WaitClick(Number2);
                        //Get the answer 
                        WaitClick(EqualTo);
                        break;
                    case "Addition":
                        //Click the number to work with 
                        WaitClick(Number);
                        //Click sign(+,-,x,/)
                        WaitClick(Add);
                        //Click the number to work with 
                        WaitClick(Number2);
                        //Get the answer 
                        WaitClick(EqualTo);
                        break;

                    default:
                        //Click the number to work with 
                        WaitClick(Number);
                        //Click sign(+,-,x,/)
                        WaitClick(Multiply);
                        //Click the number to work with 
                        WaitClick(Number2);
                        //Get the answer 
                        WaitClick(EqualTo);
                        break;
                        ;
                }
                
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
