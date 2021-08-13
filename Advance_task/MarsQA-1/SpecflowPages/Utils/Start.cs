using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            Extent = new ExtentReports(ConstantHelpers.ReportsPath, false, DisplayOrder.NewestFirst);

                     Extent.LoadConfig(ConstantHelpers.ReportXMLPath);

                     test = Extent.StartTest("Start test");
                     test = Extent.StartTest("Standard Task Test Report");


        }
        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;



        #endregion


        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(driver, "NewScreenShot");
//            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //test.Log(LogStatus.Info, "Snapshot below: " + img);


            // end test. (Reports)
            Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            Extent.Flush();

            //Close the browser
            driver.Close();
            driver.Quit();


        }
    }

}