Feature: expediaFlightBook
	Feature to search for Multi-City flight
	here we will choose the dates and destinations and calculate the cost

@SmokeTest
@Browser:Chrome
Scenario: Expedia Flight Search for Execute Automation
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
