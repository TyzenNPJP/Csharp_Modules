/*
 * Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
*/

class Program
{
    public static void Function()
    {
        for (int i=0; i<=100; i++)
        {
            if (i%2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Main(string[] args)
    {
        Function();
    }
}