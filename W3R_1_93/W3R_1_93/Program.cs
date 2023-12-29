/*
 *  Write a C# Sharp program to calculate the square root of a given number. 
 *  Return the integer part of the result instead of using any built-in functions.
*/

class Program
{
    static void Function(int num)
    {
        int sqrt = 0;

        if (num > 0)
        {
            int i = 0;
            while (i * i <= num)
            {
                sqrt = i;
                i++;
            }
            Console.WriteLine($"Nearest Sqrt of {num}: {sqrt}");
        }
        else
        {
            Console.WriteLine("Square root of a negative number cannot be computed.");
        }
    }

    static void Main(string[] args)
    {
        Function(27);
    }
}