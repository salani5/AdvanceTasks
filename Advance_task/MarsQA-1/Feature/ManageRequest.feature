Feature: ManageRequest
	As a seller I want to Manage Requests

@mytag
Scenario: User is able to Manage Received Requests
	Given User is able to succesfully Login
	When User  clicks on Manage Received Requests
	And Clicks on Accept button under Actions 
	Then Complete Action is updated 

@mytag
Scenario: User is able to Manage Sent Requests
	Given User is able to succesfully Login
	When User clicks on SKill Search icon on top left corner for the page
	And Enters user name in the search user text box and then clicks on user name
	And Clicks on the Interested Skill name and Enters message to request skill trade
	Then User is able to view the skill details by Recipient 