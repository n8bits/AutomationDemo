Feature: UserRegistration
	As a unregistered user
	I want to be able to create an account
	So that I can buy things

Background: Unregistered user on the Sign in page
	Given I am an unregistered user
	And I have navigated to the Sign in page

@registration
Scenario: Form Validation - Valid
	When I enter a valid email address in the email address field
	And I tab out of the email address field
	Then the style of the input box should change to indicate the email address is valid
