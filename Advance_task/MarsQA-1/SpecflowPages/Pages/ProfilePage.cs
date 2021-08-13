using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfilePage
    {
        #region  Initialize Web Elements 

        //Click on Edit button
        private static IWebElement AvailabilityWriteIcon => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));

        //click on profile page menu
        private static IWebElement ClickProfileMenu => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));


        //Click on Availability Time dropdown
        private static IWebElement ClickAvailabilityTime => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));



        //Click on Availability Time option
        private static IWebElement HoursWriteIcon => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));


        //Click on Availability Hour dropdown
        private static IWebElement ClickAvailabilityHours => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));

        //Click on EarnTarget writeicon
        private static IWebElement ClickEarnTarget => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));


        //select on dropdown EarnTarget
        private static IWebElement EarnTarget => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));

        //click on Lanaguage menu
        private static IWebElement LanguageMenu => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));


        //click on Description writeicon
        private static IWebElement ClickDescriptionWriteIcon => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));


        //Click on Add Button
        private static IWebElement DescriptionSaveButton => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));


        //Choose City
        private static IWebElement DescriptionEdit => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));

        //Click Language writeicon
        private static IWebElement LangWriteIcon => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));


        //Click on Add new to add new Language
        private static IWebElement AddNewLangBtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));


        //Enter the Language on text box
        private static IWebElement AddLangText => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        // 
        //Enter the Language on text box
        private static IWebElement EditTextLang => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));

        //click on lang drop down
        private static IWebElement ChooseLang => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));



        //Update Language
        private static IWebElement UpdateLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));


        //skill menu
        private static IWebElement ClickSkillMenu => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));


        //Click on Add new to add new skill
        private static IWebElement AddNewSkillBtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));


        //Enter the Skill on text box
        private static IWebElement AddSkillText => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));


        //Click on skill level dropdown
        private static IWebElement CLickChooseSkill => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));


        //Add Skill
        private static IWebElement AddSkill => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));


        //Click on Education menu
        private static IWebElement EducationMenu => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));


        //Click on Add new to Educaton
        private static IWebElement AddNewEducation => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));


        //Enter university in the text box
        private static IWebElement EnterUniversityName => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));


        //Click the country dropdown
        private static IWebElement ClickChooseCountry => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));


        //Click on Title dropdown
        private static IWebElement ClickTitleDropDown => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));


        //Degree TextBox
        private static IWebElement Degree => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));


        //click on Year of graduation
        private static IWebElement DegreeYear => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));


        //Click on Add education
        private static IWebElement AddEdu => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));


        //CLick on  Certificate menu
        private static IWebElement CertificateMenu => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));


        //Add new Certificate
        private static IWebElement AddNewCerti => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));


        //Enter Certification Name
        private static IWebElement EnterCertificate => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));


        //Certified from
        private static IWebElement CertiFrom => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));


        //Year
        private static IWebElement CertiYear => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));


        //Choose Opt from Year
        private static IWebElement CertiYearOpt => Driver.driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]"));


        //Add Ceritification
        private static IWebElement AddCerti => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));


        //Click on "Hi Salani" drop down
        private static IWebElement ClickHiSalani => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/span"));


        //Click on Change Password
        private static IWebElement ChangePassword => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/span/div/a[2]"));


        //enter current password
        private static IWebElement EnterCurrentPassword => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));



        //enter new  password
        private static IWebElement NewChangePassword => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));



        //enter confirm  password
        private static IWebElement ConfirmPassword => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input"));

        //save new  password
        private static IWebElement SavePassword => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));
        #endregion

        public static void EnterAvailabiltyHoursEarnTarget()
        {

            //click on availability writeicon
            AvailabilityWriteIcon.Click();
            //CommonWaits.ElementExists(10, By.XPath("/html/body/div[2]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            Thread.Sleep(5000);

            //select availabilty drop down
            SelectElement availabiltyTime = new SelectElement(ClickAvailabilityTime);
            availabiltyTime.SelectByText("Part Time");
            ClickAvailabilityTime.Click();
            Thread.Sleep(500);

            //click hours writeicon
            HoursWriteIcon.Click();
            Thread.Sleep(500);

            //select hours drop down
            SelectElement availabiltyHours = new SelectElement(ClickAvailabilityHours);
            availabiltyHours.SelectByText("Less than 30hours a week");

            //click on Earn Target writeicon
            ClickEarnTarget.Click();
            Thread.Sleep(500);

            //select on Earn Target dropdown
            SelectElement earnTarget = new SelectElement(EarnTarget);
            earnTarget.SelectByText("Between $500 and $1000 per month");


        }


        public static void validateAvailabiltyHoursEarnTarget()
        {
            //validate avaibility 


            String actualAvaibility = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[1]")).Text;
            Console.WriteLine(actualAvaibility);
            Assert.IsTrue(actualAvaibility.Equals("Part Time"));

            //validate Hours
            String actualHours = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[1]")).Text;
            Console.WriteLine(actualHours);
            Assert.True(actualHours.Contains("Less than 30hours a week"));

            //Validate EarnTarget
            String actualEarnTarget = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[1]")).Text;
            Console.WriteLine(actualEarnTarget);
            Assert.True(actualEarnTarget.Contains("Between $500 and $1000 per month"));
        }

        public static void clickProfileMenu()
        {
            ClickProfileMenu.Click();


        }

        public static void clickLangMenu()
        {
            LanguageMenu.Click();
        }

        public static void ClickAddNew()
        {
            AddNewLangBtn.Click();
        }
        public static void AddLanguage()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");

            //Enter Language
            AddLangText.SendKeys(ExcelLibHelper.ReadData(2, "Language"));

            //Select Lang level from drop down
            SelectElement langlevel = new SelectElement(ChooseLang);
            langlevel.SelectByText("Fluent");

            //Click Add button
            AddLangText.Click();

        }

        public static void LangWrite()
        {
            LangWriteIcon.Click();


        }

        public static void UpdateLang()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");

            EditTextLang.Clear();
            //Enter Language
            EditTextLang.SendKeys(ExcelLibHelper.ReadData(3, "Language"));

            //click update language

            UpdateLanguage.Click();


        }

        public static void ClickDescription()
        {
            ClickDescriptionWriteIcon.Click();
        }

        public static void EnterDescription()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            DescriptionEdit.Clear();
            DescriptionEdit.SendKeys(ExcelLibHelper.ReadData(2, "Description"));

            //CommonWaits.ElementExists(5, By.XPath("/html/body/div[2]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));

            DescriptionSaveButton.Click();
        }

        public static void ValidateProfileDescription()
        {
            String textProfileDescription = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
            Console.WriteLine(textProfileDescription);
            Assert.True(textProfileDescription.Contains("Automation Testing"));


        }


        public static void CLickSkill()
        {

            ClickSkillMenu.Click();

        }

        public static void AddNewSkill()
        {

            AddNewSkillBtn.Click();

        }

        public static void EnterSkill()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            AddSkillText.SendKeys(ExcelLibHelper.ReadData(2, "Skill"));
        }

        public static void SelectSkill()
        {
            //Select skill level from drop down

            SelectElement skilllevel = new SelectElement(CLickChooseSkill);
            skilllevel.SelectByText("Intermediate");
        }

        public static void ClickAddSkill()
        {

            AddSkill.Click();


        }

        public static void ValidateSkillText()
        {
            String skillText = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            Console.WriteLine(skillText);
            Assert.True(skillText.Contains("Selenium"));


        }

        public static void ClickEduMenu()
        {

            EducationMenu.Click();
        }


        public static void ClickAddNewEdu()
        {

            AddNewEducation.Click();
        }

        public static void EnterEduText()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            EnterUniversityName.SendKeys(ExcelLibHelper.ReadData(2, "University Name"));
            
        }
        public static void SelectCountryName()
        {

            SelectElement countryName = new SelectElement(ClickChooseCountry);
            countryName.SelectByText("India");
        }


        public static void SelectTitleEdu()
        {

            SelectElement titleDropDown = new SelectElement(ClickTitleDropDown);
            titleDropDown.SelectByText("B.Tech");
        }

        public static void DegreeText()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Degree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));

        }

        public static void SelectYearOfGrad()
        {

            SelectElement YearGrad = new SelectElement(DegreeYear);
            YearGrad.SelectByText("2011");

            AddEdu.Click();


        }

        public static void ClickCertMenu()
        {

            CertificateMenu.Click();
        }

        public static void ClickCertAddNew()
        {

            AddNewCerti.Click();
        }

        public static void CertName()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            EnterCertificate.SendKeys(ExcelLibHelper.ReadData(2, "Certificate"));

        }

        public static void CertFrom()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            CertiFrom.SendKeys(ExcelLibHelper.ReadData(2, "CertifiedFrom"));

        }
        public static void SelectYearOfCert()
        {

            SelectElement certiYear = new SelectElement(CertiYear);
            certiYear.SelectByText("2016");
        }

        public static void ClickCertiAdd() 
        {
            AddCerti.Click();
        }

            


        


















    }
}
