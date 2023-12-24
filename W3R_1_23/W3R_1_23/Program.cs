class Program
{
    public static string Function(string str1)
    {
        return str1.ToLower();
    }

    public static void Main(string[] args)
    {
        string str2 = Function("A Program");
        Console.WriteLine(str2);
        Console.ReadLine();
    }
}