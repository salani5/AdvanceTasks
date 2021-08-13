using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class ManageRequests
    {
        public ManageRequests()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Requests Link
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement manageRequestsLink { get; set; }

        
        //Click on Recieved RequestLink
        [FindsBy(How = How.LinkText, Using = "Received Requests")]
        private IWebElement recieveRequestLink { get; set; }

        //Click on Sent RequestLink
        [FindsBy(How = How.LinkText, Using = "Sent Requests")]
        private IWebElement sentRequestLink { get; set; }

        //Click on Accept recieved Request
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/table/tbody/tr/td[8]/button[1]")]
        private IWebElement acceptRecievedReq { get; set; }

        //Click on search icon
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[1]/div[1]/i")]
        private IWebElement searchIcon { get; set; }

        //Click on search user textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input")]
        private IWebElement searchUser { get; set; }

        //Click on automation testing
        [FindsBy(How = How.CssSelector, Using = "div.result:nth-child(1)>div:nth-child(1)>img:nth-child(2)")]
        private IWebElement MarsAdvanceClick { get; set; }

        //Click on automation testing
        [FindsBy(How = How.LinkText, Using = "Automation Testing")]
        private IWebElement AutmationTesting { get; set; }

        //Click on request skill trade message
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea")]
        private IWebElement skillTradeMessage { get; set; }

        //Click on request skill trade message
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input")]
        private IWebElement skilluserclick { get; set; }

        

        //Click on request Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]/i")]
        private IWebElement ClickRequest { get; set; }

        

        //Click on yes confirm trade request
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[3]/button[1]")]
        private IWebElement ConfirmTradeReq { get; set; }


        public void ReceivedManageRequest()
        {
            //hover mouse Manage Request
            Actions actions = new Actions(GlobalDefinitions.driver);
            actions.MoveToElement(manageRequestsLink).Build().Perform();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div[1]/div/section[1]/div/div[1]"), 20);


            //click on recieved request
            recieveRequestLink.Click();

            //click on accept icon 
            //acceptRecievedReq.Click();


            
        }


        public void SentRequest()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");




            //click on sent request
            //sentRequestLink.Click();

            //GlobalDefinitions.wait(10);



            //click on searchicon
            searchIcon.Click();

            //click on search user textbox
            searchUser.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Searh User"));

            skilluserclick.Click();



            //click on automation testing link
            MarsAdvanceClick.Click();

            AutmationTesting.Click();



            //click on Skill trade message text box
            skillTradeMessage.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill Trade Message"));

            ClickRequest.Click();

            ConfirmTradeReq.Click();

            


            









        }






















    }
}
