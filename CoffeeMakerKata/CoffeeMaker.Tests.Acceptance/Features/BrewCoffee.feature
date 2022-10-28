Feature: BrewCoffee

In order not to fall asleep
When I am not supposed to
I want to brew some coffee.

Scenario: Successful brewing
	Given a coffee maker in Standby state
	And an empty pot placed on the warmer plate
	And a boiler filled with water
	When the coffee brewing is started
	Then a pot of coffee is brewed

Scenario: Attempt brewing without water results in error
	Given a coffee maker in Standby state
	And an empty pot placed on the warmer plate
	And an empty boiler
	When the coffee brewing is started
	Then water error is reported

Scenario: Attempt brewing without a pot results in error
	Given a coffee maker in Standby state
	And no pot is placed on the warmer plate
	And a boiler filled with water
	When the coffee brewing is started
	Then pot error is reported

Scenario: Attempt brewing to a non-empty pot results in error
	Given a coffee maker in Standby state
	And a not empty pot placed on the warmer plate
	And a boiler filled with water
	When the coffee brewing is started
	Then pot error is reported
