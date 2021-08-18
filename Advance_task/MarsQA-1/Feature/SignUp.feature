Feature: SignUp 
	As a seller I want to Register on the skill swap website

@mytag
Scenario: When User enters valid details to register 
	Given User already at SkillSwap page
	When User Clicks the join button 
	And Enters valid Details and Clicks I agree check box
	And clicks on Join button
	Then User is successfully Registered at skillswap page