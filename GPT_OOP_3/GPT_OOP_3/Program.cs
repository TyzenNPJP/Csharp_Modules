public interface IAnimal
{
    public void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark\n");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow\n");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.MakeSound();

        Cat cat1 = new Cat();
        cat1.MakeSound();
    }
}