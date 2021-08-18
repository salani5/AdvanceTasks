using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ManageRequestPage
    {
        //Click on Manage Requests Link
        private static IWebElement manageRequestsLink => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[1]"));

        private static IWebElement manageRequestsLink1 => Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/section[1]/div/div[1]"));







        //Click on Recieved RequestLink
        private static IWebElement recieveRequestLink => Driver.driver.FindElement(By.LinkText("Received Requests"));


        //Click on Sent RequestLink
        private static IWebElement sentRequestLink => Driver.driver.FindElement(By.XPath("/html/body/div[2]/section[1]/div/div[1]/div/a[2]"));


        //Click on Accept recieved Request
        private static IWebElement acceptRecievedReq => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[2]/td[8]/button[1]"));


        //Click on search icon
        private static IWebElement searchIcon => Driver.driver.FindElement(By.CssSelector(".search"));


        //Click on search user textbox
        private static IWebElement searchUser => Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));

        //Click on automation testing
        private static IWebElement MarsAdvanceClick => Driver.driver.FindElement(By.CssSelector("div.result:nth-child(1)>div:nth-child(1)>img:nth-child(2)"));


        //Click on automation testing
        private static IWebElement AutmationTesting => Driver.driver.FindElement(By.LinkText("Automation Testing"));


        //Click on request skill trade message
        private static IWebElement skillTradeMessage => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea"));


        //Click on request skill trade message
        private static IWebElement skilluserclick => Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));

        //Click on request Button
        private static IWebElement ClickRequest => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]/i"));

        //Click on yes confirm trade request
        private static IWebElement ConfirmTradeReq => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[3]/button[1]"));

        
        private static IWebElement completeActions => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[3]/td[8]/button"));

        private static IWebElement WithdrawActions => Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[5]/td[8]/button"));



        public static void ReceivedManageRequest()
        {
            //hover mouse Manage Request
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(manageRequestsLink).Build().Perform();

            CommonWaits.WaitForElement(Driver.driver, By.XPath("/html/body/div[1]/div/section[1]/div/div[1]"), 20);


            //click on recieved request
            recieveRequestLink.Click();

            //click on accept icon 
            acceptRecievedReq.Click();



        }

        public static void ClickSearchIcon() 
        {
            //CommonWaits.WaitForElementToBeClickable(Driver.driver, By.XPath("/html/body/div[1]/div[1]/div[1]/i"), 20);
            //click on searchicon
            searchIcon.Click();
            Thread.Sleep(1000);
        }
        public static void SentRequest()
        {
            //Populate the Excel Sheet
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageListings");




            //click on sent request
            //sentRequestLink.Click();

            //GlobalDefinitions.wait(10);



            

            //click on search user textbox
            searchUser.SendKeys(ExcelLibHelper.ReadData(2, "Search User"));

            skilluserclick.Click();



            //click on automation testing link
            MarsAdvanceClick.Click();

           



            

            
        }


        public static void requestSKill()
        {
            //Populate the Excel Sheet
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageListings");

            AutmationTesting.Click();

            //click on Skill trade message text box
            skillTradeMessage.SendKeys(ExcelLibHelper.ReadData(2, "Skill Trade Message"));

            ClickRequest.Click();

            ConfirmTradeReq.Click();
        }
        public static void validateRecieveActions() 
        {
            //CommonWaits.ElementExists(3, By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/table/tbody/tr[3]/td[8]/button"));
            string actionsText = completeActions.Text;
            Assert.True(actionsText== "Complete");





        }

        public static void validateSentActions()
        {
            
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(manageRequestsLink1).Build().Perform();

            sentRequestLink.Click();
            Thread.Sleep(1000);

            string WithdrawText = WithdrawActions.Text;
            Assert.True(WithdrawText == "Withdraw");
            //Console.WriteLine(WithdrawText);



        }
    }


}










        



    

