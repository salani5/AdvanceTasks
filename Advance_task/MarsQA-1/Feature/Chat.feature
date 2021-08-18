Feature: ChatPage
	As a seller user is able to manage Chat functionality

@mytag
Scenario: User is able to manage chat history 
	Given User is able to succesfully Login
	When User enters chat user link and clicks on search icon
	And User clicks on chat user link and enters message and clicks on send button
	Then User is able to view the chat details