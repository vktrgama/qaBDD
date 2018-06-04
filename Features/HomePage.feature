Feature: Test my home page
	In order to avoid invalid form registration

@mytag
Scenario: CheckRegistrationForm
	Given I am on the home page of quiniela
	And page is all rederdered
	When Look for the registration form
	Then I should be able to enter my email
