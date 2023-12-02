Feature: Sign up

As a new user who wants to register

@
Scenario: New user sign up
	Given I navigate to Mentorskid website
	When I click sign up button
	And I enter first name
	And I enter last name
	And I enter email address
	And I enter password
	And I click mentee button
	And I check terms and conditions
	And I click join now button
	Then I am directed to profile page
