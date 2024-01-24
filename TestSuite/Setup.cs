using automation.framework.CoreFuntions.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automation.framework.Reports;
using automation.framework.CoreFuntions;

namespace automation.framework.TestSuite
{
    public class SetupBase
    {
        [OneTimeSetUp]
        public void OnetimeStartup()
        {
            Helpers.Hepler.createFolder("Report");
            Helpers.Hepler.createFolder("Report/screenshots");
            SeleniumSetup.Init(String.Empty);
            Reporting.initReport();
        }

        [OneTimeTearDown]
        public void OneTimeCleanUp()
        {
            Reporting.flush();
            SeleniumSetup.QuitBrowser();
        }

    }
}
