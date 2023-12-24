class Program
{
    public static int Function(int num)
    {
        int sum = 0;
        List<int> list_ints = new List<int>();
        
        while ((num/10>1) || (num%10!=0) )
        {
            list_ints.Add(num % 10);
            num = num / 10;
        }

        foreach (int i in list_ints)
        {
            sum += i;
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        int sum_disp = Function(5910);
        Console.WriteLine(sum_disp);
    }
}