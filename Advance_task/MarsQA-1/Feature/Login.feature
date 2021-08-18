Feature: Login Page 
As a seller I want to test the login functionality

@mytag
Scenario: When User enters valid credentials then it should login successfully	
    Given User already at SkillSwap page
    When User clicks at SignIn button 
    And User enters valid credentials and clicks on login button
    Then User is able to succesfully Login

