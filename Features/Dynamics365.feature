Feature: Navigate to Dynamic365 site and validate the page elements


Background: 
    Given I navigate to Google
	And I Accept All the Cookies
	Then the page title should be "Google"

Scenario: Navigate to Dynamics365 Website
	Given I search for "Dynamics 365"
	When I click on the search result for Dynamics 365
	Then the page title should be "Business Applications | Microsoft Dynamics 365"
	Then the logo image should be displayed
    And the text "Dynamics 365" should be visible
    And the header text should display "The new era of AI-powered business"
	And I wait for 10 seconds