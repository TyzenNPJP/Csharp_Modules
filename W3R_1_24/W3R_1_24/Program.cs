/*
 * Write a C# program to find the longest word in a string.
*/

class Program
{
    public static string Function (string line)
    {
        // Splits words based on space
        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

        string l_word;
        int l_word_length = 0;
        int counter = 0;
        int l_word_index = 0;
        foreach (string word in words)
        {
            if (word.Length >= l_word_length)
            {
                l_word_length = word.Length;
                l_word_index = counter;
            }
            counter++;
        }

        l_word = words[l_word_index];
        return l_word;
    }

    public static void Main(string[] args)
    {
        string line = "The collection of Words";
        string l_word = Function(line);
        Console.WriteLine(l_word);
        Console.ReadLine();
    }
}