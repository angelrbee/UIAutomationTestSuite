Feature: SignIn

@signIn
Scenario Outline: Sign In to Facebook
	Given I am in Facebook Page
	When I sign up for '<Scenario>'
	Then I am '<Result>'

Examples:
	| Scenario      | Result             |
	| ValidScenario | Successful         |
	| BlankPassword | ErrorBlankPassword | 
