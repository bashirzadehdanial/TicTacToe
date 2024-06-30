# TicTacToe Console Game

This repository contains a simple console-based TicTacToe game implemented in C#. The game allows two players to take turns marking spaces on a 3x3 board until one player wins or the game ends in a draw.

## How to Play:
- Player 1 marks 'X' and Player 2 marks 'O'.
- Each player takes turns entering a number from 1 to 9 to place their mark on the board.

## Game Rules:
- The game board is displayed after each move.
- To win, a player must have three of their marks in a row (horizontally, vertically, or diagonally).
- The game ends in a draw if all spaces are filled without a winner.

## Implementation Details:
- The game logic is implemented in a single C# file `Program.cs`.
- It utilizes basic console input/output and array manipulation for board management.
- Players' moves are validated to ensure they are within valid board positions.