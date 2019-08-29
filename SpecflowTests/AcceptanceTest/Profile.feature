Feature: Profile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add Availability in profile page
	Given I launch browser, signin and click on profile
	And I click on Availability 
	When I select availability option
	Then the result should display a message as "Availability updated"


	@mytag2
Scenario: Add Hours in profile page
	Given I launch the browser, signin and click on profile
	And I click on edit Hours icon 
	When I select options for Hours
	Then the result should display message as "Availability updated"

	@mytag3
Scenario: Add EarnTarget in profile page
	Given I launch the  browser, signin and click on profile
	And I click on EarnTarget edit icon 
	When I select options for EarnTarget
	Then the result should display the message as "Availability updated"