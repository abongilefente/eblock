/*  Author : Abongile Fente 
    Date    : 01 Oct 2023 
    Description : This code check if the Accounts has all the expected columns.  */
using automation.framework.CoreFuntions.PageObjects.CommonMethods;
using automation.framework.Reports;
using automation.framework.CoreFuntions;

namespace automation.framework.TestSuite.Merchant
{
    public class Calculator : SetupBase
    {

        private CoreFuntions.PageObjects.Calculator accounts;

        [OneTimeSetUp]
        public void Startup()
        {
            Reporting.Feature("Merchant Site");
            SeleniumSetup.NavigatetoURL("https://www.calculator.net/");         
            accounts = new CoreFuntions.PageObjects.Calculator(SeleniumSetup._driver);
        }

        /***** TEST *****/
        [Test]
        public void AccountsPage()
        {
            Reporting.Scenario("Test Acount Page");
            Reporting.StepReporter(accounts.Calculationsr("Add"), "All the columns are aval");
        }

        /***** CLOSE BROWSER *****/
        [OneTimeTearDown]
        public void CleanUp()
        {
            SeleniumSetup.QuitBrowser();
        }
    }
}
