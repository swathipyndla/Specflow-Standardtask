Feature: Description
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add data into description
	Given I launch browser and click on profile 
	And I click on edit description icon and enter some text
	When I click on save button
	Then the description should be added successfully.

	@mytag2
Scenario: Add special charecters into description
	Given I launch browser and click on profile tab
	And I click on edit  icon in description and enter some text with special charecter
	When I click on save button to add description
	Then it shows an error message  "First character can only be digit or letters"

	@mytag3
Scenario: Add Null values into description
	Given I  launch browser and click on profile tab
	And I click on edit icon in description and leave the field empty
	When I click on save button.
	Then it shows an error message "Please, a description is required"

