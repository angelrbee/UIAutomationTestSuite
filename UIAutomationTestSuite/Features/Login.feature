Feature: Login
This Feature is for Login Page

@login
Scenario: Login User
	Given I click Sign In button
	When I enter '<email>' and '<password>'
	And I click Login button
	Then I can see My Bookings page
