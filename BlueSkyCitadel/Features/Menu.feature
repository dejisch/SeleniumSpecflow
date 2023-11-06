Feature: Menu

A short summary of the feature

@tag1
Scenario: About Us Menu
	Given I navigate to website "https://mentorskid.com/"
	When I click on the menu "About Us"
	Then the url "https://mentorskid.com/how-it-work/" is displayed
	And the text "MentorSkid - Connecting you with Professionals" is displayed on the about us page

Scenario: Find A Mentor Menu
	Given I navigate to website "https://mentorskid.com/"
	When I click on the menu "Find a Mentor"
	Then the url "https://mentorskid.com/find-instructors/" is displayed
	And the text "search results found" is displayed on the find a mentor page