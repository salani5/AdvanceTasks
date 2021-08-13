Feature: Profile Page
 As a seller I want to add and update Description, Language, skill and certifications details.
 And Also I should be able to see the  details on the profile page

 @mytag
Scenario: User is able to select Avalaibilty, Hours and Earn Target details
    Given User is able to succesfully Login
	When User is already at profile page
	And User selects Availabilty,Hours and Earn Target from drop down  
	Then User is able to view Avalaibilty, Hours and Earn Target details 


  @mytag
Scenario: User is able to add Languages
    Given User is able to succesfully Login
	When User is already at profile page
	When User clicks on Language tab
	And User is able to click on Add New tab
	Then User is able to Add Language Details successfully and Save the changes made

	@mytag
Scenario: User is able to update language under languages menu
	Given User is able to succesfully Login
	When User is already at profile page
	When User clicks on Language tab
	And User Click on write icon besides language details
	Then User is able to Update Language Details successfully and Save the changes made


    @mytag
Scenario: User is able to add profile name
	Given User is able to succesfully Login
    When Click on dropdown icon below profile picture
	And Enter FirstName and LastName 
	And Click on save button
	Then user is able to view profile name

	@mytag
Scenario: User is able to add profile Description
	Given User is able to succesfully Login
    When Click on outline write icon beside Description header
	And Enter the description and click on save Button
	Then user is able to view profile description 
	
   

    @mytag
Scenario: User is able to add skills 
	Given User is able to succesfully Login
	When click on skills from menu
	And Click on Add new button 
	And Enter skill in textbox 
	And select  skill level from the drop down
	And Click on Add button
    Then User is able to view skill 

	@mytag
Scenario: User is able to add Education details 
	Given User is able to succesfully Login
	When click on Education from menu
	And Click on Add new Education button
	And Enter college name  in textbox 
	And select country of college from drop down
	And select title from the drop down
	And Enter Degree in the textbox
	And select year of graduation from the drop down and Click on Add button 
    Then User is able to view education detail 

	@mytag
Scenario: User is able to add certifications 
	Given User is able to succesfully Login
	When click on Certifications from menu
	And Click on Add new certifications button
	And Enter certificate in textbox
	And Enter certified from in textbox
    And select year from the drop down
	And Click on Add certificate button
    Then User is able to view certifications
	

	


