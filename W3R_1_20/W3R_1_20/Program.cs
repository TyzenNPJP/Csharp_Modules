/*
 * Write a C# program to get the absolute value of the difference between two given numbers. 
 * Return double the absolute value of the difference if the first number is greater than the second number. 
*/

public class Program
{
    public float Simplify(float x, float y)
    {
        float z = x - y;
        z = Math.Abs(z);
        if (x > y)
        {
            z *= 2;
            return z;
        }
        else return z;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");

        // Acts like Convert.ToInt32();
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        float y = float.Parse(Console.ReadLine());

        Program program = new Program();
        Console.WriteLine("After calculation: " + program.Simplify(x, y));
    }
}