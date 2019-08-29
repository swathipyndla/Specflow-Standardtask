Feature: Certificate_TabFeature
	In order to update my profile 
	As a skill trader
	I want perform the following opearation under Certification tab

@mytag1
Scenario: check if the user is able to add all the details of certification .
   Given I open the browser and login to the portal
	And I click on Certification under profile tab and click on Add New
	And I enter all the required details into certification
	When I press Add button to add certification details
	Then all the Certificate details should be displayed.


	
@mytag2
#Scenario Outline: check if the user is able to enter multiple certifications within the Certification tab.
#   Given I launch  browser and login to the portal
#	And I click on certification under profile tab and click on Add New
#	And I enter all details '<Certificate>','<From>','<year>' 
#	When I click on Addbutton
#	Then all the Certification details should be displayed.
#
#	Examples: 
#	      | Certificate    | From | 
#	      | Networking     | AAA  | 
#	      |Istqb           | BBB  | 
#	      | Obiee          | B.A  | 
  
#  @mytag3
#Scenario: check if the user is able to update certificate details.
#   Given I launch the browser and login to the portal
#	And I click on Certification  under profile tab and select the certification to update and click on edit
#	And I update  the required fields with new values
#	When I click on update
#	Then all the Certification details with updated data should be displayed.
#
#	
#  @mytag4
#Scenario: check if the user is able to cancel update operation for Certification details.
#   Given I launch the browser and login to the portal
#	And I click on Certification under profile tab and select the Certification  to update
#	And I click on update and
#	When I click on cancel
#	Then the update operation should be cancelled.
#
#	
  @mytag5
Scenario: check if the user is able to delete Certification details.
   Given I launch  browser and login to the portal
	And I click on Certification under profile tab and select the certification to delete
	When I click on  delete icon in certification
	Then the deleted certification details should not be displayed and gives an error message.
#
#
  @mytag6
Scenario: check if the user is able to add a certification with null values.
   Given I launch the Webbrowser and login to the portal
	And I click on Certification  under profile tab and Click on Add New
	And I leave the fields empty  
	When I click on Addbutton 
	Then it shows an error message as "Please enter Certification Name, Certification From and Certification Year" .
#                                     
#	
  @mytag7
Scenario: check if the user is able to add a certification with existing details.
   Given I open the Webbrowser and login to the portal
	And I click on Certification  under profie tab and click on Add New
	And I give all the fields with existing data.
	When I click on Addbutton in certification
	Then it should dispaly an error message as "This information is already exist."


#	
#  @mytag8
#Scenario: check if the user is able to add the certification with existing data but with different year.
#   Given I launch the browser and login to the portal
#	And I click on Certification under profie tab and click on Add New
#	And I give all the fields with existing data and give different value for year.
#	When I click on Add
#	Then it should dispaly an error message as "Duplicated data".
#





