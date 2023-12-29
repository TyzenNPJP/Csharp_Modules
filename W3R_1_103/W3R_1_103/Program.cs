/*
 * Write a C# Sharp program to sort characters in a given string (uppercase/lowercase letters and numbers). 
 * Return the newly sorted string.
*/

using System.Collections;

class Program
{
    static void Function(string line)
    {
        List<char> list_chars = new List<char>();
        List<char> list_nums = new List<char>();
        string new_line;
        int ascii;

        foreach (char c in line)
        {
            ascii = c;

            // Separate numbers and chars
            if (ascii < 48 || ascii > 57)
            {
                list_chars.Add(c);
            }
            else
            {
                list_nums.Add(c);
            }
        }
        list_nums.Sort();
        list_chars.Sort();
        new_line = String.Concat(list_chars) + String.Concat(list_nums);
        Console.WriteLine(new_line);
    }

    static void Main(string[] args)
    {
        Function("AGA91D");
    }
}