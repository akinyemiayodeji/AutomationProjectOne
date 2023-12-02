Feature: AddingTimeSlot

As a registered Mentor on Mentoskid website
I want to book a time slot
So that I can manage my appointments


@tag1
Scenario: Validate booking a time slot
	Given I navigate to Mentorskid website as a Mentor
	And I click the login button
	And I enter my email address
	And I enter my password
	And I click submit button
	And I click my calendar button
	And I click add/Edit bookings button
	And I click add new time slots button
	And I select available service days
	And I enter slot title field
	And I select start and end time from dropdown
	And I select break time from dropdown
	And I select session duration from dropdown
	And I check custom value box
	When I click Generate time slots button
	And I click save & update changes button
	Then Time slot booking should be successful
	 