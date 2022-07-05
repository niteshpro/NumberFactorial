//3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
using System;
class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter a number for its factorial:");
        var input = Convert.ToInt32(Console.ReadLine());

        var factorial = 1;
        for (int i = input; i > 0; i--)
        {
            factorial *= i;
        }
        Console.Write("{0}! = {1}",input,factorial);

    }
}