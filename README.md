# CLI Memory Card Matching Game

Term Project for CS20200

## Introduction

This project is a command-line interface (CLI) memory card matching game developed in F#.

The player selects a difficulty level and attempts to match all pairs of cards by revealing two cards at a time. The game includes randomized card placement, multiple board sizes, input validation, and attempt tracking.

The objective is to match all pairs using the fewest possible attempts.

---

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

Verify the installation with:

```bash
dotnet --version
```

The output should display a version starting with `10`.

---

## How to Run the Program

1. Clone the repository:

```bash
git clone <repository-url>
```

2. Move to the project directory:

```bash
cd card_match
```

3. Run the program:

```bash
dotnet run
```

---

## How to Play

### 1. Select Difficulty

At the beginning of the game, the player selects one of three difficulty levels.

| Difficulty | Grid Size |
|---|---|
| Easy | 4 × 4 |
| Normal | 6 × 6 |
| Hard | 8 × 8 |

Available inputs:

- `e` or `easy`
- `n` or `normal`
- `h` or `hard`

If the player enters an invalid difficulty input, the game displays an error message and asks the player to try again.

---

### 2. Card Generation and Shuffle

- The game generates matching pairs of cards based on the selected board size.
- Each pair contains the same word value.
- All cards are shuffled randomly before the game begins.

---

### 3. Board Display

- All cards initially appear face-down.
- Face-down cards are represented by numbered positions.
- Revealed cards display their values.
- Successfully matched cards remain permanently revealed.

Example:

```text
🂠 1            🂠 2            🂠 3            🂠 4
🂠 5            🂠 6            🂠 7            🂠 8
```

---

### 4. Selecting Cards

- The player selects two different card positions each turn.
- After the first selection, the chosen card is revealed.
- After the second selection:
  - If the two cards match, they stay revealed.
  - If they do not match, they are hidden again after a short delay.

---

### 5. Input Validation

The game checks for invalid inputs, including:

- Non-numeric input
- Numbers outside the valid range
- Selecting an already revealed card
- Selecting an already matched card

If invalid input is entered, the player is asked to try again.

---

### 6. Attempt Tracking

- The game records the total number of attempts.
- One attempt is counted whenever the player selects two cards.

---

### 7. Winning the Game

- The game continues until all card pairs are matched.
- After all matches are completed, the game displays:
  - A congratulatory message
  - The total number of attempts used

---

## Project Structure

```text
card_match
│
├── Program.fs      // Program entry point and difficulty selection
├── Game.fs         // Main game loop and gameplay logic
├── Board.fs        // Board creation and board rendering
├── Types.fs        // Type definitions for cards and game state
├── Utils.fs        // Utility functions such as shuffle
├── card_match.fsproj
├── requirements.md
└── README.md
```

---

## LLM Usage

(To be added later.)