Feature: BBC

As a user on BBC website
I want to read sports news


@tag1
Scenario: Validate user can read sports news
	Given I am on BBC website "https://www.bbc.co.uk/news"
	When I click sports news
	Then Sports news page should display
