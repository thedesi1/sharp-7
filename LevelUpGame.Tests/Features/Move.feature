Feature: Move
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position but does increment move count.

@acceptance
Scenario Outline: Move in a direction
    Simple example of how to test move

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player chooses to move in <direction>
    And the current move count is <startingMoveCount>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates  <endingPositionY>
    And the new move count is <endingMoveCount>
    Examples:
       
        | startingPositionX | startingPositionY | direction |startingMoveCount | endingPositionX | endingPostionY | endingMoveCount |
        | 5 | 5 | East |56| 6 | 5 |57|
        | 5 | 5 | West |65| 4 | 5 |66|
        | 5 | 5 | South |75| 5 | 4 |76|
        | 5 | 5 | North |89| 5 | 6 |90|
        | 9 | 9 | East |14| 9 | 9 |15|
        | 9 | 9 | North |33| 9 | 9 |34|
        | 0 | 9 | West |52| 0 | 9 |53|
        | 0 | 9 | North |49| 0 | 9 |50|
        | 9 | 0 | East |33| 9 | 0 |34|
        | 9 | 0 | South |19| 9 | 0 |20|
        | 0 | 0 |South |44| 0 | 0 |45|
        | 0 | 0 |West |78| 0 | 0 |79| 
        |4  | 3 |North|88| 4 | 4 |89|