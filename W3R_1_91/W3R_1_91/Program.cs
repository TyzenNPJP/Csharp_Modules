/*
 * Write a C# Sharp program to remove all values except integer values from a given array of mixed values.
*/

using System.Collections;

class Program
{
    static ArrayList Function(object[] array_obj)
    {
        ArrayList aList = new ArrayList();

        foreach (object obj in array_obj)
        {
            // To check if the obj is of integer type
            if (obj.GetType() == typeof(int))
            {
                aList.Add(obj);
            }
        }
        return aList;
    }

    static void Main(string[] args)
    {
        object[] array_obj = { 123, "Imma be", 'A', 132.432, System.DateTime.Now, 5 };
        ArrayList aList = new ArrayList();
        aList = Function(array_obj);

        foreach (int i in aList) 
        {
            Console.WriteLine(i);
        }
    }
}