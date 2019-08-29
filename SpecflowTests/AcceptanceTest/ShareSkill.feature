Feature: ShareSkill
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Adding data into share skill page
	Given I have launched browser and click on profile and click on shareskill button
	And I have entered all the required fields
	When I Click on save button
	Then the result should give a message as "Service Listing Added successfully"

	@mytag
Scenario: Adding null data into share skill page
	Given I launch browser and click on profile and click on shareskill button
	And I have given null values in the required fields
	When I Click on save button.
	Then the result should give  message as "Please complete the form correctly."

	@mytag
Scenario: Adding special charecters to title field in share skill page
	Given I launch the browser and click on profile and click on shareskill button
	When I Click on title and enter special charecter
	Then the result should give message as "First character must be an alphabet character or a number."
