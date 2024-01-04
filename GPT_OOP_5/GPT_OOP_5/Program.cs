/*
 * Abstraction: Create an abstract class Vehicle with a method Drive(). 
 * Create two derived classes Car and Motorcycle that inherit from Vehicle. 
 * Implement the Drive() method in each derived class to drive the vehicle. 
 * Create an instance of each derived class and call their Drive() methods. 
*/

public abstract class Vehicle
{
    public abstract void Drive();
}

public class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Vroom\n");
    }
}

public class Motorcycle : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Zoom\n");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        Motorcycle motorcycle = new Motorcycle();

        // Array is required to have its element size specified
        Vehicle[] array_vehicle = new Vehicle[2];

        array_vehicle[0] = car;
        array_vehicle[1] = motorcycle;

        foreach (Vehicle v in array_vehicle)
        {
            v.Drive();
        }
    }
}