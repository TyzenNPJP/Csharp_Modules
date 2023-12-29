/*
 * Write a C# Sharp program to remove all non-letter characters from a given string.
*/

class Program
{
    static string Function(string line)
    {
        int ascii_code;
        int counter = 0;
        List<char> new_line = new List<char>();

        foreach (char c in line)
        {
            ascii_code = c;
            
            // ascii code of Capital letters 
            if (ascii_code >= 65 && ascii_code <= 90)
            {
                new_line.Add(c);
            }
            // ascii code of small letters
            else if (ascii_code >= 97 && ascii_code <= 122)
            {
                new_line.Add(c);
            }
            else
            {
                counter--;
            }
            counter++;
        }

        line = string.Join("", new_line);
        return line;
    }

    static void Main(string[] args)
    {
        string line = "This is where the (story) of 8765 begins!";
        line = Function(line);
        Console.WriteLine(line);
    }
}