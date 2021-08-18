using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        private static IWebElement LoggedIn => Driver.driver.FindElement(By.LinkText("Sign Out"));
        public static void ClickSignIn()
        {
            SignInBtn.Click();
        }
        
        public static void EnterUrl()
        {
            Driver.NavigateUrl();
        }
        public static void ClickLoginBtn()
        {
            LoginBtn.Click();
        }



        public static void SigninStep()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignIn");
            
            
            Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            
        }
        public static void Login()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("salanisharma20@gmail.com");

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("Apple@123");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }

        public static void validateLoginFeature()
        {
            Assert.AreEqual(LoggedIn.Text, "Sign Out");
            Console.WriteLine(LoggedIn.Text);
        }
    }
}