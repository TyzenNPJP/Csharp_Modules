/*
 * Write a C# program to rotate an array (length 3) of integers in the left direction. 
*/

class Program
{
    static int[] arr_num = [1, 2, 3, 4, 5];

    static int[] Function(int[] arr)
    {
        int[] arr_num2 = new int[arr.Length];
        int counter = 0;

        foreach (int i in arr)
        {
            if (counter == 0)
            {
                arr_num2[arr_num.Length-1] = i;
            }
            else
            {
                arr_num2[counter-1] = i;
            }
            counter++;
        }

        return arr_num2;
    }

    static void Main(string[] args)
    {
        int[] arr_num2 = Function(arr_num);
        foreach (int i in arr_num2)
        {
            Console.WriteLine(i);
        }
    }
}