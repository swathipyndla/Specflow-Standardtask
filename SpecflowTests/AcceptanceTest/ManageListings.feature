Feature: ManageListings
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Delete a service in managelistings
	Given I launch the browser and click on managelisting
	When I select a particular service to delete and click on delete
	Then the serevice should be deleted.
