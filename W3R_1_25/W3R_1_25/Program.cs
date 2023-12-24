class Program
{
    public static void Function()
    {
        for (int i=0; i<=100; i++)
        {
            if (i%2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Main(string[] args)
    {
        Function();
    }
}