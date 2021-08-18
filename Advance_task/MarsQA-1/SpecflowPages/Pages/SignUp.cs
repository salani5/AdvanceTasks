using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class SignUp
    {
        #region  Initialize Web Elements 
        //Finding the Join 
        private static IWebElement Join => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));

        //Identify FirstName Textbox
        private static IWebElement FirstName => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));

        //Identify LastName Textbox
        private static IWebElement LastName => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));

        //Identify Email Textbox
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));

        //Identify Password Textbox
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));

        //Identify Confirm Password Textbox
        private static IWebElement ConfirmPassword => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));

        //Identify Term and Conditions Checkbox
        private static IWebElement Checkbox => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));

        //Identify join button
        private static IWebElement JoinBtn => Driver.driver.FindElement(By.Id("submit-btn"));
        #endregion

        public static void CLickJoinBtn()
        {
            Join.Click();
            CommonWaits.wait(5);
        }

        public static void EnterValidDetails()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignUp");

            //Enter FirstName
            FirstName.SendKeys(ExcelLibHelper.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(ExcelLibHelper.ReadData(2, "LastName"));

            //Enter EmailAddress
            Email.SendKeys(ExcelLibHelper.ReadData(2, "EmailAddress"));

            //Enter Password
            Password.SendKeys(ExcelLibHelper.ReadData(2, "Password"));

            // Enter confirm Password
            ConfirmPassword.SendKeys(ExcelLibHelper.ReadData(2, "Password"));

            //Click on check box "I agree"

            Checkbox.Click();
        }

        public static void ClickJoinButton() 
        {
            JoinBtn.Click();
            CommonWaits.wait(10);


        }









        
















    }
}
