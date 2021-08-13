using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps_Bindings
{
    [Binding]
    public  class ProgramTest
    {

        private readonly IWebDriver driver;
        


        [Given(@"User already at SkillSwap page")]
        public void GivenUserAlreadyAtSkillSwapPage()
        {
            SignIn.EnterUrl();
           
        }

        [When(@"User clicks at SignIn button")]
        public void WhenUserClicksAtSignInButton()
        {
            SignIn.ClickSignIn();
        }

        [When(@"User enters valid credentials and clicks on login button")]
        public void WhenUserEntersValidCredentialsAndClicksOnLoginButton()
        {
            SignIn.SigninStep();
            SignIn.ClickLoginBtn();
        }

        [Then(@"User is able to succesfully Login")]
        public void ThenUserIsAbleToSuccesfullyLogin()
        {
            SignIn.validateLoginFeature();
        }

        [When(@"User Clicks the join button")]
        public void WhenUserClicksTheJoinButton()
        {
            SignUp.CLickJoinBtn();
        }

        [When(@"Enters valid Details and Clicks I agree check box")]
        public void WhenEntersValidDetailsAndClicksIAgreeCheckBox()
        {
            SignUp.EnterValidDetails();
        }

        [When(@"clicks on Join button")]
        public void WhenClicksOnJoinButton()
        {
            SignUp.ClickJoinButton();
        }

        [Then(@"User is successfully Registered at skillswap page")]
        public void ThenUserIsSuccessfullyRegisteredAtSkillswapPage()
        {
            //SignIn.validateLoginFeature();
        }

        [Given(@"User is able to succesfully Login")]
        public void GivenUserIsAbleToSuccesfullyLogin()
        {
            SignIn.Login();
        }



        [When(@"User selects Availabilty,Hours and Earn Target from drop down")]
        public void WhenUserSelectsAvailabiltyHoursAndEarnTargetFromDropDown()
        {
            ProfilePage.EnterAvailabiltyHoursEarnTarget();


        }

        [Then(@"User is able to view Avalaibilty, Hours and Earn Target details")]
        public void ThenUserIsAbleToViewAvalaibiltyHoursAndEarnTargetDetails()
        {
            ProfilePage.validateAvailabiltyHoursEarnTarget();
        }

        [When(@"User is already at profile page")]
        public void WhenUserIsAlreadyAtProfilePage()
        {
            ProfilePage.clickProfileMenu();
        }

        [When(@"User clicks on Language tab")]
        public void WhenUserClicksOnLanguageTab()
        {
            ProfilePage.clickLangMenu();
        }

        [When(@"User is able to click on Add New tab")]
        public void WhenUserIsAbleToClickOnAddNewTab()
        {
            ProfilePage.ClickAddNew();
        }

        [Then(@"User is able to Add Language Details successfully and Save the changes made")]
        public void ThenUserIsAbleToAddLanguageDetailsSuccessfullyAndSaveTheChangesMade()
        {
            ProfilePage.AddLanguage();
        }

        

        [When(@"User Click on write icon besides language details")]
        public void WhenUserClickOnWriteIconBesidesLanguageDetails()
        {
            ProfilePage.LangWrite();
        }

        [Then(@"User is able to Update Language Details successfully and Save the changes made")]
        public void ThenUserIsAbleToUpdateLanguageDetailsSuccessfullyAndSaveTheChangesMade()
        {
            ProfilePage.UpdateLang();
        }

       

        [When(@"Click on dropdown icon below profile picture")]
        public void WhenClickOnDropdownIconBelowProfilePicture()
        {
           
        }

        [When(@"Enter FirstName and LastName")]
        public void WhenEnterFirstNameAndLastName()
        {
           
        }

        [When(@"Click on save button")]
        public void WhenClickOnSaveButton()
        {
           
        }

        [Then(@"user is able to view profile name")]
        public void ThenUserIsAbleToViewProfileName()
        {
            
        }

        [When(@"Click on outline write icon beside Description header")]
        public void WhenClickOnOutlineWriteIconBesideDescriptionHeader()
        {
            ProfilePage.ClickDescription();
        }

        [When(@"Enter the description and click on save Button")]
        public void WhenEnterTheDescriptionAndClickOnSaveButton()
        {
            ProfilePage.EnterDescription();

        }

        [Then(@"user is able to view profile description")]
        public void ThenUserIsAbleToViewProfileDescription()
        {
            ProfilePage.ValidateProfileDescription();
        }

        [When(@"click on skills from menu")]
        public void WhenClickOnSkillsFromMenu()
        {
            ProfilePage.CLickSkill();
        }

        [When(@"Click on Add new button")]
        public void WhenClickOnAddNewButton()
        {
            ProfilePage.AddNewSkill();
        }

        [When(@"Enter skill in textbox")]
        public void WhenEnterSkillInTextbox()
        {
            ProfilePage.EnterSkill();


        }

        [When(@"select  skill level from the drop down")]
        public void WhenSelectSkillLevelFromTheDropDown()
        {
            ProfilePage.SelectSkill();
        }

        [When(@"Click on Add button")]
        public void WhenClickOnAddButton()
        {
            ProfilePage.ClickAddSkill();


        }

        [Then(@"User is able to view skill")]
        public void ThenUserIsAbleToViewSkill()
        {
            ProfilePage.ValidateSkillText();
        }

        [When(@"click on Education from menu")]
        public void WhenClickOnEducationFromMenu()
        {
            ProfilePage.ClickEduMenu();


        }

        [When(@"Click on Add new Education button")]
        public void WhenClickOnAddNewEducationButton()
        {
            ProfilePage.ClickAddNewEdu();
        }

        [When(@"Enter college name  in textbox")]
        public void WhenEnterCollegeNameInTextbox()
        {
            ProfilePage.EnterEduText();
        }

        [When(@"select country of college from drop down")]
        public void WhenSelectCountryOfCollegeFromDropDown()
        {
            ProfilePage.SelectCountryName();
        }

        [When(@"select title from the drop down")]
        public void WhenSelectTitleFromTheDropDown()
        {
            ProfilePage.SelectTitleEdu();
        }

        [When(@"Enter Degree in the textbox")]
        public void WhenEnterDegreeInTheTextbox()
        {
            ProfilePage.DegreeText();
        }

        [When(@"select year of graduation from the drop down and Click on Add button")]
        public void WhenSelectYearOfGraduationFromTheDropDownAndClickOnAddButton()
        {
            ProfilePage.SelectYearOfGrad();
        }

        [Then(@"User is able to view education detail")]
        public void ThenUserIsAbleToViewEducationDetail()
        {
          
        }

        [When(@"click on Certifications from menu")]
        public void WhenClickOnCertificationsFromMenu()
        {
            ProfilePage.ClickCertMenu();
        }

        [When(@"Click on Add new certifications button")]
        public void WhenClickOnAddNewCertificationsButton()
        {
            ProfilePage.ClickCertAddNew();
        }

        [When(@"Enter certificate in textbox")]
        public void WhenEnterCertificateInTextbox()
        {
            ProfilePage.CertName();
        }

        [When(@"Enter certified from in textbox")]
        public void WhenEnterCertifiedFromInTextbox()
        {
            ProfilePage.CertFrom();

        }

        

        [When(@"select year from the drop down")]
        public void WhenSelectYearFromTheDropDown()
        {
            ProfilePage.SelectYearOfCert();
        }

        
        [When(@"Click on Add certificate button")]
        public void WhenClickOnAddCertificateButton()
        {
            ProfilePage.ClickCertiAdd();
        }

        [Then(@"User is able to view certifications")]
        public void ThenUserIsAbleToViewCertifications()
        {
         
        }
        [When(@"User Clicks on Share Skill Button")]
        public void WhenUserClicksOnShareSkillButton()
        {
            ShareSkillPage.ClickShareSkillButton();
        }

        [When(@"Enters Title and Decription")]
        public void WhenEntersTitleAndDecription()
        {
            ShareSkillPage.EnterTitleAndDescription();
        }

        [When(@"selects Category, Sub-Category from drop down")]
        public void WhenSelectsCategorySub_CategoryFromDropDown()
        {
            ShareSkillPage.selectCategorySubCategory();
        }

        [When(@"Enter tags and skill-exchange")]
        public void WhenEnterTagsAndSkill_Exchange()
        {
            ShareSkillPage.EntertagsAndskillExchange();
        }

        [When(@"Clicks on Service-type, Location-type, Skill-trade , Active checkboxes")]
        public void WhenClicksOnService_TypeLocation_TypeSkill_TradeActiveCheckboxes()
        {
            ShareSkillPage.clickServiceLocationSkilltradeActive();
        }

        [When(@"Selects start date , end date and checks weekday under available days category")]
        public void WhenSelectsStartDateEndDateAndChecksWeekdayUnderAvailableDaysCategory()
        {
            ShareSkillPage.availableDays();
        }

        [When(@"Clicks on work-sample plus button to upload file")]
        public void WhenClicksOnWork_SamplePlusButtonToUploadFile()
        {
            
        }

        [When(@"clicks on save button")]
        public void WhenClicksOnSaveButton()
        {
            ShareSkillPage.ClickSave();
        }

        [Then(@"User is able to view saved skill under manage listings menu")]
        public void ThenUserIsAbleToViewSavedSkillUnderManageListingsMenu()
        {
            
        }

        [When(@"User clicks on ManageListings Link")]
        public void WhenUserClicksOnManageListingsLink()
        {
            ManageListingsPage.clickManageListings();
        }

        [When(@"User Clicks on view eye icon")]
        public void WhenUserClicksOnViewEyeIcon()
        {
            ManageListingsPage.ViewListings();
            Thread.Sleep(500);
        }

        [Then(@"user is able to view the skill listing details")]
        public void ThenUserIsAbleToViewTheSkillListingDetails()
        {
            ManageListingsPage.validateViewListings();


        }

        [When(@"User Clicks on write icon of Skill listings")]
        public void WhenUserClicksOnWriteIconOfSkillListings()
        {
            ManageListingsPage.ClickEditListingsIcon();
        }

        [When(@"Enter on title textbox to update the title of the listings")]
        public void WhenEnterOnTitleTextboxToUpdateTheTitleOfTheListings()
        {
            ManageListingsPage.EditListings();
        }

        [Then(@"user is able to view the updated skill listing details")]
        public void ThenUserIsAbleToViewTheUpdatedSkillListingDetails()
        {
            ManageListingsPage.validateEditListings();
        }

        [When(@"User clicks on  remove icon of Skill listings")]
        public void WhenUserClicksOnRemoveIconOfSkillListings()
        {
            ManageListingsPage.removeListings();
        }

        [Then(@"user is not able to view the delete the skill listing details")]
        public void ThenUserIsNotAbleToViewTheDeleteTheSkillListingDetails()
        {
            ManageListingsPage.validateRemoveIcon();
        }

        [When(@"User  clicks on Manage Received Requests")]
        public void WhenUserClicksOnManageReceivedRequests()
        {
            ManageRequestPage.ReceivedManageRequest();
        }

        [When(@"Clicks on Accept button under Actions")]
        public void WhenClicksOnAcceptButtonUnderActions()
        {
            
        }

        [Then(@"Complete Action is updated")]
        public void ThenCompleteActionIsUpdated()
        {
            ManageRequestPage.validateRecieveActions();


        }

        [When(@"User clicks on SKill Search icon on top left corner for the page")]
        public void WhenUserClicksOnSKillSearchIconOnTopLeftCornerForThePage()
        {
            ManageRequestPage.ClickSearchIcon();
        }

        [When(@"Enters user name in the search user text box and then clicks on user name")]
        public void WhenEntersUserNameInTheSearchUserTextBoxAndThenClicksOnUserName()
        {
            ManageRequestPage.SentRequest();
        }

        [When(@"Clicks on the Interested Skill name and Enters message to request skill trade")]
        public void WhenClicksOnTheInterestedSkillNameAndEntersMessageToRequestSkillTrade()
        {
            ManageRequestPage.requestSKill();
        }
        [Then(@"User is able to view the skill details by Recipient")]
        public void ThenUserIsAbleToViewTheSkillDetailsByRecipient()
        {
            ManageRequestPage.validateSentActions();
        }

        [When(@"User Hovers mouse on Notifications tab")]
        public void WhenUserHoversMouseOnNotificationsTab()
        {
            NotificationsPage.NotificationsHover();
        }

        [When(@"performs click action on See All Link")]
        public void WhenPerformsClickActionOnSeeAllLink()
        {
            NotificationsPage.ClickSeeAll();
        }

        [Then(@"User is able to view the Notification lists")]
        public void ThenUserIsAbleToViewTheNotificationLists()
        {
            NotificationsPage.ValidateNotificationsList();
        }

        [When(@"performs click action on Mark All as Read Link")]
        public void WhenPerformsClickActionOnMarkAllAsReadLink()
        {
            NotificationsPage.ClickOnMarkAsRead();
        }

        [Then(@"User is able to view Notifications list in Normal font.")]
        public void ThenUserIsAbleToViewNotificationsListInNormalFont_()
        {
            NotificationsPage.ValidateNotificationsMarkAllRead();
        }

        [When(@"User CLicks on  radio button to select the service request notification")]
        public void WhenUserCLicksOnRadioButtonToSelectTheServiceRequestNotification()
        {
            NotificationsPage.notificationsCheckBox();
        }

        [When(@"Clicks on Delete icon to perform Delete actions")]
        public void WhenClicksOnDeleteIconToPerformDeleteActions()
        {
            NotificationsPage.ClickDeleteActions();
        }

        [Then(@"User is not able to view the deleted notification")]
        public void ThenUserIsNotAbleToViewTheDeletedNotification()
        {
            NotificationsPage.ValidateDelete();
        }

        [When(@"User enters chat user link and clicks on search icon")]
        public void WhenUserEntersChatUserLinkAndClicksOnSearchIcon()
        {
            ChatPage.clickChatLink();
        }

        [When(@"User clicks on chat user link and enters message and clicks on send button")]
        public void WhenUserClicksOnChatUserLinkAndEntersMessageAndClicksOnSendButton()
        {
            ChatPage.ChatHistory();
        }

        [Then(@"User is able to view the chat details")]
        public void ThenUserIsAbleToViewTheChatDetails()
        {
            
        }















    }
}
