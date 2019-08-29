Feature:Skills tab feature
	In order to update my profile 
	As a skill trader
	I want perform the following opearation in skills tab

@mytag1
Scenario: Check if the user is able to Add skills under skills tab
	Given I am  able to launch the browser and login to the dashboard 
	And I click on Skills_tab under profile page and click on Add new
	And enter some text into the skills Textbox and choose the level of skills
	When I press Add button
	Then skill with its level should be added and displayed.

	@mytag2
Scenario Outline: Check if the user is able to Add Multiple skills under skills tab
	Given I am able to launch the browser and login to the portal 
	And I click on Skills tab under profile page and click on Add new
	And enter '<skills>' into the skills and choose the level of skills
	When I press Add 
	Then skills with its level should be added and dispalyed.
	 
	 Examples:
	         | skills |
	         | Java   |
	         | Sql    |
	         | C#     |


@mytag3
Scenario: Check if the user is able to update skills under skills tab
	Given Iam able to launch the browser and login to the portal 
	And I click on Skills tab
	And I choose a language to update and click on edit 
	And I clear the existing data and enter new one and choose the level
    When I click on update
	Then updated skills with its level should be added and displayed.

@mytag4
Scenario: Check if the user is able to delete a particualr skill under skills tab
	Given I am  able to launch the browser and login to the portal 
	And I click on Skills tab under profile page 
	And I choose a language to delete
	When I click on  delete 
	Then skills with its level should be deleted.

#	@mytag5
#Scenario: Check if the user is able to cancel edit operation 
#	Given I am  able to launch the browser and login to the portal 
#	And I click on Skills tab under profile page 
#	And I choose a language to update and click on edit 
#    When I click on cancel
#	Then update operation should be cancelled.

	@mytag6
Scenario: Check if the user is able to add existing data
	Given I  launch the browser and login to the portal 
	And I click on Skills tab  under profile page 
	And I enter existing skills with same level 
    When I click on Add
	Then it should display an error message as "This skill is already exists in your skills list".

	@mytag7
Scenario: Check if the user could be able to add duplicate data.
	Given I  click on the  Skills  tab under Profile page 
	When I try to add the existing Skills with different language level
	Then it should throw an error as "Duplicated data".


	@mytag8
Scenario: Check if the user is able to give null values
	Given Iam able to launch browser and login to the portal 
	And I click on Skills tab under profile page.
	And I click on Add new and leave the skills tab or skills level tab empty
    When I click on Add button
	Then it should throw an error message as "Please enter skill and experience level".











