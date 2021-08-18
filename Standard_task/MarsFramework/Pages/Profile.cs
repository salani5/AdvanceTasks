using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 

        //Click on Edit button
       [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement AvailabilityWriteIcon { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select")]
        private IWebElement ClickAvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement HoursWriteIcon { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select")]
        private IWebElement ClickAvailabilityHours { get; set; }

        //Click on EarnTarget writeicon
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement ClickEarnTarget { get; set; }

        //select on dropdown EarnTarget
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select")]
        private IWebElement EarnTarget { get; set; }

        //click on Description writeicon
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        private IWebElement ClickDescriptionWriteIcon { get; set; }

        //Click on Add Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        private IWebElement DescriptionAddButton { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        private IWebElement DescriptionEdit { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //click on lang drop down
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //skill menu
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        private IWebElement ClickSkillMenu { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement CLickChooseSkill { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Education menu
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        private IWebElement EducationMenu { get; set; }

        //Click on Add new to Educaton
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversityName { get; set; }

        //Click the country dropdwon
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ClickChooseCountry { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ClickTitleDropDown { get; set; }

        //Degree TextBox
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //click on Year of graduation
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Click on Add education
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //CLick on  Certificate menu
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        private IWebElement CertificateMenu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCertificate { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Click on "Hi Salani" drop down
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/span")]
        private IWebElement ClickHiSalani { get; set; }

        //Click on Change Password
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/span/div/a[2]")]
        private IWebElement ChangePassword { get; set; }

        //enter current password

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[1]/input")]
        private IWebElement EnterCurrentPassword { get; set; }

        //enter new  password

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[2]/input")]
        private IWebElement NewChangePassword { get; set; }

        //enter confirm  password

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[3]/input")]
        private IWebElement ConfirmPassword { get; set; }

        

        //save new  password

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[4]/button")]
        private IWebElement SavePassword { get; set; }



        #endregion

        public void EditProfile()
        {
            
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //click on time writeicon
            AvailabilityWriteIcon.Click();
            Thread.Sleep(500);

            //select dropdowwn  Availability
            SelectElement availabiltyTime = new SelectElement(ClickAvailabilityTime);
            availabiltyTime.SelectByText("Full Time");

            //click on hours writeicon
            HoursWriteIcon.Click();
            Thread.Sleep(500);

            //select hours dropdown
            SelectElement availabiltyHours = new SelectElement(ClickAvailabilityHours);
            availabiltyHours.SelectByText("Less than 30hours a week");

            //click on Earn Target writeicon
            ClickEarnTarget.Click();
            Thread.Sleep(500);

            //select on Earn Target dropdown
            SelectElement earnTarget = new SelectElement(EarnTarget);
            earnTarget.SelectByText("Between $500 and $1000 per month");

            //click on write icon Description
            ClickDescriptionWriteIcon.Click();

            //Enter Description
            DescriptionEdit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //click Add button Description
            DescriptionAddButton.Click();

            //Click Lang Addnew button
            AddNewLangBtn.Click();

            //Enter Add Lang text
            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Choose the lang-level dropdown
            SelectElement langlevel = new SelectElement(ChooseLang);
            langlevel.SelectByText("Conversational");

            //click on Add Lang
            AddLang.Click();

            //click on skills menu 
            ClickSkillMenu.Click();

            //Click on skill AddNew Button
            AddNewSkillBtn.Click();

            //Click on Skill textbox
            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

            //select drop down
            SelectElement skillDropDown = new SelectElement(CLickChooseSkill);
            skillDropDown.SelectByText("Intermediate");

            //Add Skill button
            AddSkill.Click();

            // click on Education menu
            EducationMenu.Click();

            //Click on Edu Addnew button
            AddNewEducation.Click();

            //Enter University Name
            EnterUniversityName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //select drop down country of university
            SelectElement countryUniversity = new SelectElement(ClickChooseCountry);
            countryUniversity.SelectByText("India");

            //Select on title dropdown
            SelectElement titleOptions = new SelectElement(ClickTitleDropDown);
            titleOptions.SelectByText("B.Tech");

            //Enter Degree textbox 
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Select year of graduation
            SelectElement selectYear = new SelectElement(DegreeYear);
            selectYear.SelectByText("2015");

            //Click Add button
            AddEdu.Click();

            //click on certificate menu
            CertificateMenu.Click();

            //click on Addnew button
            AddNewCerti.Click();

            //Enter certificate name
            EnterCertificate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Enter certificate from
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Select certificate year
            SelectElement certiYear = new SelectElement(CertiYear);
            certiYear.SelectByText("2017");

            //Add Certificate
            AddCerti.Click();

            //Click on Hi Salani
            ClickHiSalani.Click();

            //click on change passord
            ChangePassword.Click();

            //Enter Current password
            //EnterCurrentPassword.SendKeys("Qwerty@123");

            //Enter New  Password
            //NewChangePassword.SendKeys("Apple@123");

            //Enter Confirm Password
            //ConfirmPassword.SendKeys("Apple@123");

            //save password
            //SavePassword.Click();












        }
    }
}