using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.IO;
using System.Threading;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Global
{
    public class Base
    {
        #region To access Path from resource file

        public static int Browser = Int32.Parse(MarsResource.Browser);
        public static string ExcelPath = MarsResource.ExcelPath;
        public static string ScreenshotPath = MarsResource.ScreenShotPath;
        //public static string ReportPath = MarsResource.ReportPath;
        public static string XmlReportPath = MarsResource.ReportXMLPath;

        public static string ReportPath = MarsResource.ReportPath;

        #endregion

        #region reports
        public static ExtentTest test;  
        public static ExtentReports extent;
        
        #endregion


       
        

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            switch (Browser)
            {

                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;
                case 2:
                    GlobalDefinitions.driver = new ChromeDriver(@"D:\ChromeDriver");
                    GlobalDefinitions.driver.Manage().Window.Maximize();
                   
                    break;

            }




            #region Initialise Reports


            extent = new ExtentReports(ReportPath, false,DisplayOrder.NewestFirst);
            extent.LoadConfig(XmlReportPath);
            test = extent.StartTest("Start test");





            #endregion

            if (MarsResource.IsLogin == "true")
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }

        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Report");
            //AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            test.Log(LogStatus.Info, "Image example: " +img);

            //end test. (Reports)
            extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            extent.Flush();

            // Close the driver            
             GlobalDefinitions.driver.Close();
             GlobalDefinitions.driver.Quit();
        }
        #endregion

    }
}