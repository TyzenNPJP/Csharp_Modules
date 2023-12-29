/*
 * Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
*/

class Program
{
    static int[] arr1 = [1, 2, 3];
    static int[] arr2 = [1, 3, 5];
    static int[] arr3 = [2, 4, 6];

    static int[] Function(int[] arr1, int[] arr2, int[] arr3)
    {
        int[][] arr_all = new int[3][] ;
        arr_all[0] = arr1;
        arr_all[1] = arr2;
        arr_all[2] = arr3;
        int[] arr_new = new int[3];

        for (int i=0; i<3; i++)
        {
            for (int j = 0; j < arr1.Length; j++) 
            { 
                // Could have used half of length
                if (j == 1)
                {
                    arr_new[i] = arr_all[i][j];
                }
            }
        }

        return arr_new;
    }

    static void Main(string[] args)
    {
        int[] arr_new = Function(arr1 , arr2, arr3);

        foreach (int i in arr_new)
        {
            Console.WriteLine(i);
        }
    }
}