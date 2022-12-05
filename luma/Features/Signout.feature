Feature: Signout
	As a user I want to be able to signout

@signout
Scenario: Perform Signout
	Given that user sign in
	And user in account page
	When user click drop down profile menu
	Then user click signout