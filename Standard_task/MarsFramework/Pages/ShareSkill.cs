using AutoItX3Lib;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace MarsFramework.Pages
{
    public class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }



        //Select the Service type
        //[FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        [FindsBy(How = How.XPath, Using = "//html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement ServiceTypeOptions { get; set; }


        //Select the Location Type
        //[FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }




        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Day Check Box
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]
        private IList<IWebElement> CheckBox { get; set; }

        //Start Time
        [FindsBy(How = How.Name, Using = "StartTime")]
        private IList<IWebElement> Start_Time { get; set; }

        //End Time
        [FindsBy(How = How.Name, Using = "EndTime")]
        private IList<IWebElement> EndTime { get; set; }

        //Enter the amount for work sample upload
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement WorkSampleUpload { get; set; }


        public void ClickShareSkillButton()
        {
            GlobalDefinitions.WaitForElementToBeClickable(GlobalDefinitions.driver, By.LinkText("Share Skill"), 10);
            ShareSkillButton.Click();

        }



        public void EnterShareSkill()
        {
            //Populate data from excel sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");



            //Enter Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Enter Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Select categoryDropdown
            SelectElement categoryDropdown = new SelectElement(CategoryDropDown);
            categoryDropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "CategoryDropdown"));

            //select SubCategoryDropDown
            SelectElement subCategoryDropdown = new SelectElement(SubCategoryDropDown);
            subCategoryDropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategorydropdown"));

            //Enter tags is textbox
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            //Select radio button service type
            //ServiceTypeOptions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType"));
            ServiceTypeOptions.Click();

            //select radio button location type
            LocationTypeOption.Click();
        }

        public void availableDays()
        {
            //Populate data from excel sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            //Start time and end time
            for (int DaysCount = 2; DaysCount < 3; DaysCount++)
            {
                // Select CheckBox
                //CheckBox[DaysCount-2].Click();

                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[1]/div/input")).Click();
                GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[1]/div/input")).Click();

                for (int count = 2; count < 4; count++)
                {
                    string StartTimeData = GlobalDefinitions.ExcelLib.ReadData(DaysCount, "Starttime");
                    string EndTimeData = GlobalDefinitions.ExcelLib.ReadData(DaysCount, "Endtime");

                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).Click();

                    if (count == 2)
                    {
                        //GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).Click();
                        GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).SendKeys(StartTimeData);
                    }
                    else
                    {
                        //GlobalDefinitions.driver.FindElement( By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).Click();
                        GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).SendKeys(EndTimeData);
                    }
                }
            }
        }

        public void SkillTrade()
        {
            //click on skill trade
            SkillTradeOption.Click();

        }
        public void SkillExchangeTags()
        {
            //Populate data from excel sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            //skill-exchange tags
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);
        }

        public void WorkSamplesUpload() 
        {
            // click work sample upload option
            WorkSampleUpload.Click();

            //activate window
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("File Upload");


            autoIt.Send(@"D:\File_name\Up.txt");

            GlobalDefinitions.wait(30);

            autoIt.Send("{ENTER}");





        }

        public void ClickActiveOption()
        {
            //Click active check box
            ActiveOption.Click();
        }
        public void ClickSave()
        {
            //Save
            Save.Click();
        }








    }




}












