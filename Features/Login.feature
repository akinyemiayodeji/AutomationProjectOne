Feature: Login

As a user on Mentorskid website
I want to login
So that I can book an appointment

@
Scenario: Validate I can login
	Given I navigate to the Mentorskid website
	And I click login button
	And I enter email address
	And I enter password
	When I click submit button
	Then I am directed to the profile page
