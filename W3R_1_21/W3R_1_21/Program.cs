/*
 * Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.
 *
*/

class Program
{
    public bool twentyfunc(int a, int b)
    {
        int c = a + b;
        if (a == 20 || c == 20)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Main(String[] args)
    {
        Program program = new Program();
        bool ret = program.twentyfunc(20, 15);
        Console.WriteLine(ret);
        Console.ReadLine();
    }
}