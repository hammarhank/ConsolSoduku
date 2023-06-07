# ConsolSoduku
Welcome to our console-based Sudoku Solver program! This program was developed to generate and solve Sudoku puzzles using a backtracking algorithm.

How It Works

The program utilizes a SudokuBoard class to generate and solve Sudoku puzzles. Here's a brief overview of the program flow:

The SudokuBoard class contains a GenerateBoard() method that generates a Sudoku board using a backtracking algorithm.
The GenerateBoard() method calls the private GenerateBoardFill() method to fill in the cells of the board recursively.
The GenerateBoardFill() method backtracks and tries different values for each cell until a valid Sudoku board is generated.
The program then calls the PrintBoard() method to display the generated Sudoku board on the console.
The PrintBoard() method iterates over the board and prints the values of each cell. It also adds visual separators to improve readability.

Prerequisites

To run this program on your local machine, make sure you have the following installed:

.NET Framework: The program is implemented using C# and requires the .NET Framework to run.
License

This program is licensed under the MIT License.

Credits
This program was developed by Amir Hebib.

Enjoy using the Console Sudoku Solver! 🧩
