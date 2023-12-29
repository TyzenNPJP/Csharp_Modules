/*
 * Write a C# program that finds the longest common prefix from an array of strings.
*/

class Program
{
    static void Function(List<string> list_words)
    {
        List<char> list_common = new List<char>();
        string? common;
        int counter = 0;

        // Iterate through all the words
        foreach(string word in list_words)
        {
            // Copy the first word
            if (counter == 0)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    list_common.Add(word[i]);
                }
            }

            // For every other word than the first
            else
            {
                // Iterate on the letters of each words
                for (int j=0; j<word.Length; j++)
                {
                    // Store the common letters
                    if (j<list_common.Count-1 && word[j] == list_common[j])
                    {
                        list_common[j] = word[j];
                    }
                    // Remove the uncommon letters in the common_list
                    else 
                    {
                        if (list_common.Count >= j)
                        {
                            list_common.RemoveRange(j, list_common.Count - j);
                            break;
                        }
                    }
                }
            }
            counter++;
        }

        common = String.Concat(list_common);
        Console.WriteLine($"Common letters: {common}");
    }

    static void Main(string[] args)
    {
        List<string> list_words = new List<string>()
        { "Protoss", "Profession", "Prime"};
        Function(list_words);
    }
}