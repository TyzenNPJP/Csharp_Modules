/*
 * Write a C# program to compute the sum of the first 500 prime numbers.
*/

class Program
{
    public static void Function()
    {
        int sum = 0;
        int count = 1;
        for (int i=2; i<=1000000; i++)
        {
            if (i == 2 || i == 3)
            {
                sum = sum + i;
                Console.WriteLine(i);
                count++;
            }

            else if (count <= 500)
            {
                for (int j=i-1; j>=2; j--)
                {
                    if (i%j == 0)
                    {
                        break;
                    }
                    if (j == 2)
                    {
                        sum = sum + i;
                        Console.WriteLine(i);
                        count++;
                    }
                }
            }
        }

        Console.WriteLine(sum);
    }

    public static void Main(string[] args)
    {
        Function();
    }
}