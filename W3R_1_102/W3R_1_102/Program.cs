/*
 * Write a C# Sharp program to create an identity matrix.
*/

class Program
{
    static void Function(int rank)
    {
        for (int i=0; i<rank; i++)
        {
            for (int j=0; j<rank; j++)
            {
                if (i == j)
                {
                    Console.Write(1 + "\t");
                }
                else
                {
                    Console.Write(0 + "\t");
                    if (j == rank-1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Function(3);
    }
}