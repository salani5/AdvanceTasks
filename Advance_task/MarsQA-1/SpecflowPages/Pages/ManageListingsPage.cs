using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageListingsPage
    {
        //Click on Manage Listings Link
        private static IWebElement manageListingsLink => Driver.driver.FindElement(By.LinkText("Manage Listings"));



        //SKill-title
        private static IWebElement skillTitle => Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));


        //View the listing
        private static IWebElement view => Driver.driver.FindElement(By.XPath("(//i[@class='eye icon'])[1]"));

        //Delete the listing
        private static IWebElement removeIcon => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[last()]/td[8]/div/button[3]/i"));


        //static int iRow = 1;
        //Edit the listing
        //[FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private static IWebElement writeIcon => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        

        //save
        private static IWebElement saveButton => Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[11]/div/input[1]"));



        //Click on Yes or No
        private static IWebElement clickActionsButton => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]"));


        public static void clickManageListings()
        {
            CommonWaits.WaitForElementToBeClickable(Driver.driver, By.LinkText("Manage Listings"), 10);

            //click on managelistings
            manageListingsLink.Click();

        }
        public static void ViewListings()
        {
            //click on writeicon
            view.Click();
        }

        public static void ClickEditListingsIcon() 
        {
           
            writeIcon.Click();


        }
        public static void EditListings()
        {
            //Populate the Excel Sheet
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkill");

            //clear title textbox
            skillTitle.Clear();

            //Edit title
            skillTitle.SendKeys(ExcelLibHelper.ReadData(3, "Title"));

            //Save
            saveButton.Click();
            Thread.Sleep(500);
        }
        public static void DeleteListings()
        {
           
            

            //click remove button
            removeIcon.Click();
            //CommonWaits.WaitForElementToBeClickable(Driver.driver, By.XPath("/html/body/div[3]/div/div[3]/button[1]"), 10);

            
            
            //click yes button
            clickActionsButton.Click();
            CommonWaits.WaitForElementToBeClickable(Driver.driver, By.XPath("/html/body/div[3]/div/div[3]/button[1]"), 10);
            IAlert alert = Driver.driver.SwitchTo().Alert();
            alert.Accept();
            //Thread.Sleep(1000);




        }
        public static void validateViewListings()
        {
            //CommonWaits.ElementExists( 5,By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/div[2]/div/div[1]/h3"));
            

            String RequestSkillTrade = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div[1]/h3")).Text;
           
            Console.WriteLine(RequestSkillTrade);

            Assert.True(RequestSkillTrade.Contains("Request Skill Trade"));


        }

        public static void validateEditListings()
        {
            //CommonWaits.ElementExists(5, By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/div[2]/div/div[1]/h3"));

            writeIcon.Click();

            String TitleChange = Driver.driver.FindElement(By.Name("title")).GetAttribute("value");
           

            Console.WriteLine(TitleChange);

            Assert.True(TitleChange.Equals("Automation Testing"));
            // Thread.Sleep(500);
            // IWebElement tableELement = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table"));

            // Thread.Sleep(500);
            // //get all table rows
            // List<IWebElement> rowList = new List<IWebElement>(tableELement.FindElements(By.TagName("tr")));
            // Thread.Sleep(500);
            // //for every row
            // string titleName = null;
            // if (rowList.Count > 0)
            // {



            //     IWebElement rowElement = rowList[0];
            //     Thread.Sleep(500);
            //     List<IWebElement> innerRowList = new List<IWebElement>(rowElement.FindElements(By.LinkText("Automation Testing")));
            //     Thread.Sleep(500);
            //     if (innerRowList.Count > 0)
            //     {
            //         IWebElement innerRowElement = innerRowList[0];
            //         titleName = innerRowElement.Text;

            //     }
            //     else
            //     {
            //         Assert.Fail("No inner row present");

            //     }
            // }
            // else
            // {
            //     Assert.Fail("No row present");
            // }

            ////Assert.Equals(titleName== "");
            // Assert.True(titleName.Contains(ExcelLibHelper.ReadData(3, "Title")));
        }

        public static void removeListings()
        {
            removeIcon.Click();

            //click yes button
            clickActionsButton.Click();
        }
        public static void validateRemoveIcon()
        {
            Assert.IsTrue(removeIcon.Displayed);
            Console.WriteLine(removeIcon.Displayed);
        }






        

        








    }
}
