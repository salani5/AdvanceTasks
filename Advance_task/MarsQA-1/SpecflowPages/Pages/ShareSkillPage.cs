using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ShareSkillPage
    {
        //Click on ShareSkill Button
        private static IWebElement ShareSkillButton => Driver.driver.FindElement(By.LinkText("Share Skill"));


        //Enter the Title in textbox
        private static IWebElement Title => Driver.driver.FindElement(By.Name("title"));


        //Enter the Description in textbox
        private static IWebElement Description => Driver.driver.FindElement(By.Name("description"));


        //Click on Category Dropdown
        private static IWebElement CategoryDropDown => Driver.driver.FindElement(By.Name("categoryId"));


        //Click on SubCategory Dropdown
        private static IWebElement SubCategoryDropDown => Driver.driver.FindElement(By.Name("subcategoryId"));


        //Enter Tag names in textbox
        private static IWebElement Tags => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));




        //Select the Service type
        //[FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private static IWebElement ServiceTypeOptions => Driver.driver.FindElement(By.XPath("//html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));



        //Select the Location Type
        //[FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private static IWebElement LocationTypeOption => Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));


        //Click on Start Date dropdown
        private static IWebElement StartDateDropDown => Driver.driver.FindElement(By.Name("startDate"));


        //Click on End Date dropdown
        private static IWebElement EndDateDropDown => Driver.driver.FindElement(By.Name("endDate"));


        //Storing the table of available days
        private static IWebElement Days => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]"));


        //Storing the starttime
        private static IWebElement StartTime => Driver.driver.FindElement(By.XPath("//div[3]/div[2]/input[1]"));


        //Click on StartTime dropdown
        private static IWebElement StartTimeDropDown => Driver.driver.FindElement(By.XPath("//div[3]/div[2]/input[1]"));


        //Click on EndTime dropdown
        private static IWebElement EndTimeDropDown => Driver.driver.FindElement(By.XPath("//div[3]/div[3]/input[1]"));

        //Click on Skill Trade option
        private static IWebElement SkillTradeOption => Driver.driver.FindElement(By.XPath("//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']"));


        //Enter Skill Exchange
        private static IWebElement SkillExchange => Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));


        //Enter the amount for Credit
        private static IWebElement CreditAmount => Driver.driver.FindElement(By.XPath("//input[@placeholder='Amount']"));


        //Click on Active/Hidden option
        private static IWebElement ActiveOption => Driver.driver.FindElement(By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']"));


        //Click on Save button
        private static IWebElement Save => Driver.driver.FindElement(By.XPath("//input[@value='Save']"));


        //Day Check Box
        private static IWebElement CheckBox => Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));


        //Start Time
        private static IWebElement Start_Time => Driver.driver.FindElement(By.Name("StartTime"));


        //End Time
        private static IWebElement EndTime => Driver.driver.FindElement(By.Name("EndTime"));


        //Enter the amount for work sample upload
        private static IWebElement WorkSampleUpload => Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

        public static void ClickShareSkillButton()
        {
            CommonWaits.WaitForElementToBeClickable(Driver.driver, By.LinkText("Share Skill"), 10);
            ShareSkillButton.Click();

        }
        public  static void EnterTitleAndDescription()
        {
            //Populate data from excel sheet
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkill");



            //Enter Title
            Title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));

            //Enter Description
            Description.SendKeys(ExcelLibHelper.ReadData(2, "Description"));

            

            

            
        }

        public static void selectCategorySubCategory() 
        {
            //Select categoryDropdown
            SelectElement categoryDropdown = new SelectElement(CategoryDropDown);
            categoryDropdown.SelectByText(ExcelLibHelper.ReadData(2, "CategoryDropdown"));

            //select SubCategoryDropDown
            SelectElement subCategoryDropdown = new SelectElement(SubCategoryDropDown);
            subCategoryDropdown.SelectByText(ExcelLibHelper.ReadData(2, "SubCategorydropdown"));
        }

        public static void EntertagsAndskillExchange()
        {
            //Populate data from excel sheet
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkill");

            //Enter tags is textbox
            Tags.SendKeys(ExcelLibHelper.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            //skill-exchange tags
            SkillExchange.SendKeys(ExcelLibHelper.ReadData(2, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);

            
        }

        public static void clickServiceLocationSkilltradeActive() 
        {
            //Select radio button service type
            //ServiceTypeOptions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType"));
            ServiceTypeOptions.Click();

            //select radio button location type
            LocationTypeOption.Click();

            //click on skill trade
            SkillTradeOption.Click();

            //Click active check box
            ActiveOption.Click();
        }

        public static void availableDays()
        {
            //Populate data from excel sheet
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkill");

            //Start time and end time
            for (int DaysCount = 2; DaysCount < 3; DaysCount++)
            {
                // Select CheckBox
                //CheckBox[DaysCount-2].Click();

                Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[1]/div/input")).Click();

                for (int count = 2; count < 4; count++)
                {
                    string StartTimeData = ExcelLibHelper.ReadData(DaysCount, "Starttime");
                    string EndTimeData = ExcelLibHelper.ReadData(DaysCount, "Endtime");

                    Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).Click();

                    if (count == 2)
                    {
                        //GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).Click();
                        Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).SendKeys(StartTimeData);
                    }
                    else
                    {
                        //GlobalDefinitions.driver.FindElement( By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).Click();
                        Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + DaysCount + "]/div[" + count + "]/input")).SendKeys(EndTimeData);
                    }
                }
            }
        }

        public static void ClickSave()
        {
            //Save
            Save.Click();
        }

    }
}
