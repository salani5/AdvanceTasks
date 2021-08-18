using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            private IWebDriver driver;


            [Test]
            public void profileEdit() 
            {
                Profile profilePage = new Profile();
                profilePage.EditProfile();



            }


            [Test]
            public void LoginTest()
            {
                //Instantiate SignIn class object
                SignIn signInPage = new SignIn();

                //wait
                //GlobalDefinitions.WaitForElement(driver, By.XPath("/html/body/div/div/div/div/div/div[1]/div/a"), 5);

                //SignIn Page
                signInPage.LoginSteps();

                //GlobalDefinitions.WaitForElement(driver, By.XPath("/html/body/div[1]/div/section[1]/div/div[2]/a"), 5);

              
             }

            [Test]
            public void createShareSkill() {

                ShareSkill shareSkillPage = new ShareSkill();


                //click shareskill button
                shareSkillPage.ClickShareSkillButton();

                //ShareSkill page
                shareSkillPage.EnterShareSkill();

                //click on available days
                shareSkillPage.availableDays();

                //click on work sample upload
                shareSkillPage.WorkSamplesUpload();


                //click on shareskilltrade options
                shareSkillPage.SkillTrade();

                //click on share skill tags
                shareSkillPage.SkillExchangeTags();

                //click on Active option
                shareSkillPage.ClickActiveOption();

                //click save button
                shareSkillPage.ClickSave();





            }
            [Test]
            public void EditShareSKill()
            {


                ManageListings manageListingsPage = new ManageListings();

                //click managelistings button
                manageListingsPage.clickManageListings();


                //edit title
                manageListingsPage.EditListings();
            }




            


            [Test]
            public void deleteManageListings() 
            {

                ManageListings manageListingsPage = new ManageListings();

                //click managelistings button
                manageListingsPage.clickManageListings();

                manageListingsPage.DeleteListings();
            }


            [Test]
            public void ManageRequest()
            {

                ManageRequests manageRequest = new ManageRequests();

                manageRequest.ReceivedManageRequest();

                manageRequest.SentRequest();
            }



            [Test]
            public void NotificationsManage() 
            {
                Notifications notifications = new Notifications();
                notifications.NotificationsRequest();

                notifications.ValidateNotificationsMarkAllRead();



            }
            [Test]
            public void ChatManage()
            {
                Chat chatManage = new Chat();
                chatManage.ChatHistory();



            }


















        }



            }



        }
    
