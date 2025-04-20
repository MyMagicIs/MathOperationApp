using System;  // Import the System namespace to use Console and other basic features

namespace MathOperationApp
{
    // Define a class called MathClass
    class MathClass
    {
        // A void method that takes two integers
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Do a math operation on the first integer (for example, multiply by 2)
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine("The result of the operation on the first number is: " + result);

            // Display the 2nd number to the screen
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    // Main program starts here
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathClass
            MathClass mathObj = new MathClass();

            // Call the method using positional arguments
            mathObj.PerformOperation(10, 5);

            // Call the method using named arguments
            mathObj.PerformOperation(firstNumber: 7, secondNumber: 3);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
