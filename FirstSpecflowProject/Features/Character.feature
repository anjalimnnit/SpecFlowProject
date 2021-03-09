Feature: Playing a game
         In order to play a game
         As a gamer
         I want to be sure that the characterstics ofthe character are calculated correctly
Background: 
Given : I am a new player

         Scenario Outline: Hitting Player
         When I got hit by <damage>
         Then My health should be <health>
         Examples: 
         | damage | health |
         | 0      | 100    |
         | 60     | 50     |
         | 80     | 30     |

         Scenario: Spell and Armor has effect on health
         And : I have the following properties:
         | prop  | value      |
         | Spell | GreenBlock |
         | Wear  | 30         |
         When I got hot by 80
         Then My health shoulld be 45

        Scenario: A character can carry on weapons
            And I have the folowing weapons
            | Name  | Price | Power |
            | Knife | 100   | 50    |
            | Axe | 250   | 60    |
            | Pistol | 1000  | 100    |
         When I got robbed on Knife
         Then I should have only two weapons
