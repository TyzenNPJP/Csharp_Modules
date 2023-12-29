/*
 * Write a C# Sharp program to remove the first and last elements from a given string.
*/

class Program
{
    static string word1 = "ASPQRT";

    static string Function(string word1)
    {
        char[] word2 = new char[word1.Length-2];
        int counter1 = 0;
        int counter2 = 0;
        string word3 = "";

        foreach (char c in word1)
        {
            if ((counter1 != 0) && (counter1 != word1.Length - 1))
            {
                word2[counter2] = c;
                counter2++;
            }
            counter1++;
        }

        foreach (char c in word2)
        {
            word3 = word3 + c;
        }

        return word3;
    }

    static void Main(string[] args)
    {
        string word4 = Function(word1);
        Console.WriteLine(word4);
    }
}