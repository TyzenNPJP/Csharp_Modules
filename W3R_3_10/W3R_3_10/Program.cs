/*
 *  Write a C# program that reads a number from the user and calculates its square root. 
 *  Handle the exception if the number is negative.
*/

using System;

public class negativity_Exception : Exception
{
    public negativity_Exception(string message) : base(message) { }
}

class Program
{
    static void sqrt(int num)
    {
        try
        {
            double ans_num = Math.Sqrt(num);

            if (num < 0)
            {
                throw new negativity_Exception("Error: A negative number cannot have a square root.");
            }
        }
        catch (negativity_Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Main(string[] args)
    {
        sqrt(-5);
    }

}

