/*
 * Write a C# program to find the size of a specified file in bytes.
*/

class Program
{
    public static void Main(string[] args)
    {
        FileInfo f = new FileInfo("T:\\CODE\\Csharp_Modules\\W3R_1_29\\W3R_1_29/file.txt");
        Console.WriteLine("The size of the file is: " + f.Length.ToString());
    }
}