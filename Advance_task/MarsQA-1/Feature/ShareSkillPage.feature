Feature: ShareSkillPage
	As a seller I want to add share skill details.

@mytag
Scenario: User is able to add share skill 
	Given User is able to succesfully Login
	When User Clicks on Share Skill Button 
	And Enters Title and Decription
	And selects Category, Sub-Category from drop down
	And Enter tags and skill-exchange
	And Clicks on Service-type, Location-type, Skill-trade , Active checkboxes
	And Selects start date , end date and checks weekday under available days category
	And Clicks on work-sample plus button to upload file
	And clicks on save button
	Then User is able to view saved skill under manage listings menu  