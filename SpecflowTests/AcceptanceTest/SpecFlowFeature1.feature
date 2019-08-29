Feature: Language tab feature
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag1
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

	
@mytag2
Scenario Outline: Check user could able to add multiple languages
	Given I  click on the Language tab under Profile page
	When I add new '<language>' and  add level
	#Then is managed in the above code
	Then all the languages with language level should be displayed on my listings
	
	Examples: 
	              | language  |
	              | Tamil     |
	              | Malayalam |
	              | Urdu      |
	              | Telugu    | 





	 @mytag3
Scenario: Check if user could be able to update a language 
	Given I click on the Language  tab under Profile page 
	When I click on edit 
	And I add a new language and click on update
	Then  updated language should be displayed on my listings



	 @mytag4
Scenario: Check if user could be able to cancel update operation within the language 
	Given I  click on  the Language  tab under Profile page 
	When I click on edit and click on cancel
	Then the update operation should be cancelled


	@mytag5
Scenario: Check if user could be able to delete a language 
	Given I  click on the Language  tab under Profile page 
	When I click on delete
	Then the deleted language should not be displayed on my listings

	
	@mytag6
Scenario: Check if the user could be able to add an Exisiting language 
	Given I  click on the  Language  tab under Profile page 
	When I try to add the language that already exists
	Then it should throw an error as "Language already exists in your languages" .

	
	@mytag7
Scenario: Check if the user could be able to add duplicate data.
	Given I  click on the  Language  tab under Profile page 
	When I try to add the language that already exists with different language level
	Then it should throw an error as "Duplicate data".


	
	@mytag8
Scenario: Check if the user could be able to give null values
	Given I  click on the Language tab  under Profile page
	When I click on Add language
	When I leave the text box empty for language or don't choose any language level
	Then it should throw an errror as please enter language and level.


