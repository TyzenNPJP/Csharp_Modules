/*
 * Write a C# Sharp program to count the number of ones and zeros in the binary representation of a given integer.
*/

class Program
{
    static void Function(int decinum)
    {
        int dividend = 2;
        List<int> quotient = new List<int>();
        int counter_0 = 0;
        int counter_1 = 0;
        
        while (dividend != 1 && dividend != 0)
        {
            // Adding quotients
            if (decinum % 2 == 0)
            {
                quotient.Add(decinum % 2);
                counter_0++;
            }
            else if (decinum % 2 == 1)
            {
                quotient.Add(decinum % 2);
                counter_1++;
            }
            
            dividend = decinum / 2;
            decinum = dividend;

            // Adding the remainder At the end
            if (dividend == 0 )
            {
                quotient.Add(dividend);
                counter_0++;
            }
            else if (dividend == 1)
            {
                quotient.Add(dividend);
                counter_1++;
            }
        }

        Console.WriteLine($"Nums of 0s: {counter_0}");
        Console.WriteLine($"Nums of 1s: {counter_1}");
        Console.Write("The binary number: ");

        quotient.Reverse();
        foreach (int i in quotient)
        {
            Console.Write(i);
        }
    }

    static void Main(string[] args)
    {
        int decinum = 8;
        Function(decinum);
    }
}