Feature: SpecflowAssistMethods
	Trying to implemet SpecFlow Assist methods


Scenario: Create Instance method
	Given I entered the following data into the new account form:
| Field              | Value      |
| Name               | John Galt  |
| Birthdate          | 2/2/1902   |
| HeightInInches     | 72         |
| BankAccountBalance | 1234.56    |

Scenario: Create Set method
Given These products exists
  | Category           | Name             | Price |
| BOOK1            | Atlas Shrugged   | 25.04 |
| BOOK2            | The Fountainhead | 20.15 |

  
Scenario: Create Dynamic Instance method

Given "The information of an employee
| Name      | EmployeeId | Designation           |
| Anjali    | E001        | Software Engineer     |
| Muskan    | E002        | Software Engineer     |
| Aayush    | E003        | Software Technologist |
| Nagashree | E004        | Product Owner         |




