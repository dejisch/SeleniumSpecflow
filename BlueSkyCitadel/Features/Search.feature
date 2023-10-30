Feature: Search

	As a user of PrepMajor.com
	I want to search for a course
	So that I can enrol for the course
@tag1
Scenario: Search for a course
	Given I navigate to PrepMajor.com
	When I click on the search field
	And I type automation in the search field
	And I click on the search button
	Then the result page is displayed
