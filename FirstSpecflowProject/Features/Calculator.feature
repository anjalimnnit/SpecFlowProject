Feature: Calculator

@longrunning
Scenario Outline: Operate two numbers
	Given I have a Calculator
	When I apply <operation> on <first> and <second>
	Then the result should be <result>
	
	Examples: 
	| operation | first | second | result |
	| add       | 40    | 25     | 65     |
	| subtract  | 34    | 10     | 24     |
	| multiply  | 25    | 4      | 100    |
	| divide    | 50    | 2      | 25    |