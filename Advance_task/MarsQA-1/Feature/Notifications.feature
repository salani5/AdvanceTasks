Feature: Notifications
	As a seller I want to manage notifications functionality

@mytag
Scenario: User is able to click see All functionality
	Given User is able to succesfully Login
	When User Hovers mouse on Notifications tab 
	And performs click action on See All Link
	Then User is able to view the Notification lists

@mytag
Scenario: User is able to click Mark All as Read functionality
	Given User is able to succesfully Login
	When  User Hovers mouse on Notifications tab 
	And   performs click action on Mark All as Read Link
	Then  User is able to view Notifications list in Normal font.

@mytag
Scenario: User is able to manage Select and delete functionality
	Given User is able to succesfully Login
	When  User Hovers mouse on Notifications tab 
	And   performs click action on See All Link 
	And   User CLicks on  radio button to select the service request notification
	And   Clicks on Delete icon to perform Delete actions
    Then  User is not able to view the deleted notification

