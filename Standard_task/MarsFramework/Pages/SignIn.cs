using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialize Web Elements

        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[1]/div/a")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        private IWebElement LoginBtn { get; set; }

        #endregion

    

        public void LoginSteps()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            //Navigate to url
            GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            //clickSignIn
            SignIntab.Click();
            

            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));
            GlobalDefinitions.wait(10);

            //click loginButton
            LoginBtn.Click();
            GlobalDefinitions.wait(10);

        }
    }
}