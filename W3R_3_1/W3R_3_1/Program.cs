﻿/*
 * Write a C# program that prompts the user to input two numbers and divides them. 
 * Handle an exception when the user enters non-numeric values.
*/

class Program
{
    static void Function(string num1, string num2)
    {
        int num3;
        try
        {
            int num_1 = Convert.ToInt32(num1);
            int num_2 = Convert.ToInt32(num2);

            if (num_2 != 0)
            {
                num3 = num_1 / num_2;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

        }
        // Catch an expected exception
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid format of the input numbers.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("try catch block is performed.");
        }
    }

    static void Main(string[] args)
    {
        Function("2", "A");
    }
}