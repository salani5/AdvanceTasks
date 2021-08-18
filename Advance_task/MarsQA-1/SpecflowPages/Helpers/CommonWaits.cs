using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    public class CommonWaits:Driver
    {
        #region WaitforElement 

        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, By element, int Secs)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Secs));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void ElementExists(int secs, By locator)
        {

            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(secs));
            w.Until(ExpectedConditions.ElementExists(locator));
        }
        #endregion

    }
}
