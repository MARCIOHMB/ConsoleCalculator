# ConsoleCalculator

This is a simple C# console-based calculator application that allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division. 
The program takes numeric inputs from the user, performs the selected operation, and provides the result. 
It includes error handling to ensure the user inputs only numeric values and does not attempt to divide by zero.

# Usage

Run the program, and you will be greeted with a welcome message.
Enter the first numeric value when prompted.
Enter the second numeric value when prompted.

Choose the operation you want to perform:
+ for addition
- for subtraction
* for multiplication
/ for division

The result of the operation will be displayed.
If you attempt to divide by zero, the program will catch this and display an error message.
After each calculation, the program will ask if you want to perform another calculation. Enter "yes" to continue or any other input to exit the program.
The program will keep running until the user decides to exit.

# Exception Handling

The program includes exception handling to address two specific scenarios:
-  FormatException: Ensures that the user enters only numeric values.
-  DivideByZeroException: Prevents the user from attempting to divide by zero.

# How to Run
Compile and run the program using a C# development environment such as Visual Studio or Visual Studio Code. 
Follow the on-screen prompts to perform calculations

Feel free to explore and modify the code as needed. Enjoy calculating!
