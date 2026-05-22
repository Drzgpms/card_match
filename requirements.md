**Project Title**: CLI Memory Card Matching Game

**Overview**: This project is a command-line memory card matching game where the user flips two cards at a time to find matching pairs. The goal is to match all pairs with the fewest number of attempts.

**Requirements**:
1. At the start of the game, the user will select a difficulty level: easy, normal, or hard.
2.  Each difficulty corresponds to a different grid size:
    - easy: 4x4 grid
    - normal: 6x6 grid
    - hard: 8x8 grid
3. The game will generate pairs of matching cards based on the selected grid size and shuffle them randomly. 
4. All cards will initially be face-down and represented by numbered positions. 
5. The user will select two different positions per turn to reveal cards. 
6. If the selected positions are valid and not already matched: 
    - The cards will be revealed. 
    - If the two cards match, they remain revealed. 
    - If they do not match, they will be hidden again. 
7. If the user selects an invalid input (out of range, same position twice, or already matched), the user will be asked to retry. 
8. The game continues until all pairs are successfully matched. 
9. The game will track the number of attempts made by the user. 
10. When all pairs are matched, the game ends and displays the total number of attempts.


**Example Interaction**: The game begins by asking the user to choose a difficulty level. The user inputs e. The game prints a 4x4 grid with numbered cards. The user inputs 3 and 7. The cards selected reveal and do not match. They become hidden again and asks the user for the next cards to reveal.