Feature: UserRegistration
	As a unregistered user
	I want to be able to create an account
	So that I can buy things

Background: Unregistered user on the Sign in page
	Given I am an unregistered user
	And I have navigated to the Sign in page

@registration
Scenario: Email Address Field Validation Indicator
	When I enter a valid email address in the email address field
	And I tab out of the email address field
	Then the style of the input box should change to indicate the email address is valid

Scenario Outline: Attempt to begin registration with invalid email
	When I attempt to begin registration using the email adress "<Email Address>" 
	Then I should not be taken to the Account Creation page
	And I should see an alert indicating the email address entered is invalid

	Examples: 
		| Email Address                        |
		| 1234125                              |
		| 12341234@3333                        |
		| @domain.com                          |
		| invalidcharacterindomain@blabla&.com |
		|                                      |