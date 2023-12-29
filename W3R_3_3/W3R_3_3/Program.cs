/*
 *  Write a C# program that reads a file path from the user and tries to open the file. 
 *  Handle exceptions if the file does not exist.
*/

using System.IO;

class Program
{
    static void read_file(string path)
    {
        try
        {
            string line = File.ReadAllText(path);
            Console.WriteLine(line);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Main(string[] args)
    {
        read_file("T:\\CODE\\Csharp_Modules\\W3R_3_3\\W3R_3_3\\file.txt");
    }
}