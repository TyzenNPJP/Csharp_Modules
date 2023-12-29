/*
 * Write a C# program that prompts the user to input a numeric integer and 
 * throws an exception if the number is less than 0 or greater than 1000.
*/

class Program
{
    // 2nd Declaration & placement of custom-made exception
    static void find_range(int num)
    {
        if (num < 0 || num > 1000)
        {
            throw new Range_Exception("Error: The number is not between 0 and 1000");
        }
    }

    // Declaration of custom-made exception
    public class Range_Exception : Exception
    {
        public Range_Exception(string message) : base(message) { }
    }

    static void Main(string[] args)
    {
        try
        {
            find_range(1005);
        }
        catch(Range_Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}