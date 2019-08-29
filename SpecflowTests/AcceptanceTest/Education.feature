Feature: Education
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag1
Scenario: check if the user is able to Add details into education background.
   Given I launched the browser and login to the portal
	And I click on Education tab  under profile tab and click on Add New
	And I enter all the required details in education tab
	When I press Add button to add Education
	Then all the  Education data should be displayed.

	 @mytag2
Scenario: check if the user is able to add the details with null values.
   Given I launched browser and login to the portal
	And I click on Education  under profile tab and Click on Add New
	And I leave the fields empty in education tab 
	When I click on Add button in education tab
	Then it shows an error message as "Please enter all the fields" 

	 @mytag3
Scenario: check if the user is able to add the education details with existing data with different year.
   Given I launch the browser and login to  portal
	And I click on Education  under profie tab and click on Add New
	And I give all the fields with existing data and give different value for year.
	When I click on Add Button
	Then it should dispaly an error message as "Duplicated data".

	@mytag4
Scenario: check if the user is able to delete eduation details.
   Given I launch the browser and login to the portal
	And I click on Education  under profile tab and select the education to delete
	When I click on delete icon in education
	Then the deleted education details should not be displayed and gives a message as "Education entry successfully removed".


