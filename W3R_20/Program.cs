public class Program
{
    public float Simplify(float x, float y)
    {
        float z = x - y;
        z = Math.Abs(z);
        if (x > y)
        {
            z *= 2;
            return z;
        }
        else return 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        float y = float.Parse(Console.ReadLine());

        Program program = new Program();
        Console.WriteLine("After calculation: " + program.Simplify(x, y));
    }
}