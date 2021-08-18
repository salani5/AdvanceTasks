Feature: ManageListings
	As a seller I want to view, update and delete  skill Listings

@mytag
Scenario: User is able to view Skill Listings 
	Given User is able to succesfully Login
	When  User clicks on ManageListings Link
	And User Clicks on view eye icon  
	Then user is able to view the skill listing details 
	
@mytag
Scenario: User is able to Edit Skill Listings 
	Given User is able to succesfully Login
	When  User clicks on ManageListings Link
	And User Clicks on write icon of Skill listings	
	And Enter on title textbox to update the title of the listings
	Then user is able to view the updated skill listing details 

	@mytag
Scenario: User is able to Delete Skill Listings 
	Given User is able to succesfully Login
	When  User clicks on ManageListings Link
	And User clicks on  remove icon of Skill listings	
	Then user is not able to view the delete the skill listing details 
