using automation.framework.CoreFuntions;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;


namespace automation.framework.Reports
{
    public class Reporting
    {
        public static ExtentTest test;
        public static ExtentReports extent;
        public static ExtentTest scenario;
        public static int count=0;
        public static void initReport()
        {
            extent = new ExtentReports();
           // scenario = new ExtentTest();
            var htmlreporter = new ExtentHtmlReporter(@"Report/Report" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            extent.AttachReporter(htmlreporter);

        }
        public static void Feature(string Test)
        {
           
            test = extent.CreateTest(Test);

        }
        public static void Scenario(string Scenario)
        {
            scenario = test.CreateNode(Scenario);
        }
         
        public static void StepReporter(bool status, string Info)
        {
            string path = String.Format("Report/screenshots/image{0}.png", count);
            string htmlInfo = string.Format("<b>{0}</b>",Info) + "<br><br>";
            
            Screenshot ss = ((ITakesScreenshot)SeleniumSetup._driver).GetScreenshot();
            ss.SaveAsFile(path,
            ScreenshotImageFormat.Png);
            switch (status)
            { 
                case true:
                    
                    scenario.Log(Status.Pass, htmlInfo, MediaEntityBuilder.CreateScreenCaptureFromPath(String.Format("screenshots/image{0}.png", count)).Build());
                    Assert.IsTrue(status, Info);
                    count++;
                    break;
                case false:
                    scenario.Log(Status.Fail, htmlInfo, MediaEntityBuilder.CreateScreenCaptureFromPath(String.Format("screenshots/image{0}.png", count)).Build());
                    Assert.IsTrue(status, Info);
                    count++;

                    break;
            }
        }
        public static void flush()
        { 
            extent.Flush(); 
        }
    }
}
