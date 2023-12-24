class Program
{
    public static bool check(int num)
    {
        if (Math.Abs(num - 100) <= 20 || Math.Abs(num - 200) <= 20)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Main(string[] args)
    {
        bool bl = check(120);
        Console.WriteLine(bl);
        Console.ReadLine();
    }
}