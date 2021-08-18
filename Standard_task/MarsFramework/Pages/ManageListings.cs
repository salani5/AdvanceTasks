using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework.Pages
{
    public class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        
        //SKill-title
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement skillTitle { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[2]/td[8]/div/button[3]/i")]
        private IWebElement removeIcon { get; set; }

        
        //Edit the listing
        //[FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
        private IWebElement writeIcon { get; set; }
        
        //save
        
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement saveButton { get; set; }


        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[1]")]
        private IWebElement clickActionsButton { get; set; }

        public void clickManageListings() 
        {
            GlobalDefinitions.WaitForElementToBeClickable(GlobalDefinitions.driver, By.LinkText("Manage Listings"), 10);

            //click on managelistings
            manageListingsLink.Click();

        }

        public void EditListings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

            

            //click on writeicon
            writeIcon.Click();

            //clear title textbox
            skillTitle.Clear();

            //Edit title
            skillTitle.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Save
            saveButton.Click();

            
            


            

        }

        public void DeleteListings()
        {
            
            //apply wait
            GlobalDefinitions.WaitForElementToBeClickable(GlobalDefinitions.driver, By.LinkText("Manage Listings"), 10);

            //click remove button
            removeIcon.Click();

            //handle pop-up alert
            //GlobalDefinitions.driver.SwitchTo().Alert().Dismiss();

            //click yes button
            clickActionsButton.Click();
            Console.WriteLine("passed");



        }


        //Verify listings
        public bool viewShareSkillPage()
        {
            return skillTitle.Displayed;
        }
    }
}
