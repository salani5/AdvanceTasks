using MarsFramework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsFramework.Specflow_steps
{
    [Binding]
    public  class Login_Steps
    {

        private readonly IWebDriver driver;
        private SignIn signInPage;
        private Profile profilePage;

        [Given(@"User already at Loginpage")]
        public void GivenUserAlreadyAtLoginpage()
        {
          


        }

        [When(@"User clicks at SignIn button")]
        public void WhenUserClicksAtSignInButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User enters valid credentials '(.*)' '(.*)' and clicks on login button")]
        public void WhenUserEntersValidCredentialsAndClicksOnLoginButton(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User is able to succesfully Login")]
        public void ThenUserIsAbleToSuccesfullyLogin()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
