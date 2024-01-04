/*
 * Inheritance: 
 * Create a base class Vehicle with properties Make, Model, and Year. 
 * Create two derived classes Car and Truck that inherit from Vehicle. 
 * Add properties number of engine cylinders and odometer to Car and Truck, respectively. 
 * Create an instance of each derived class and set their properties. 
 * Print the values of the properties to the console.
*/

public class Vehicle
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }
}

public class Car : Vehicle
{
    public string? color { get; set; }
}

public class Truck : Vehicle
{
    public int odometerKM;
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Make = "Tesla";
        car1.Model = "ModelY";
        car1.Year = 2020;
        car1.color = "Red";

        Truck truck1 = new Truck();
        truck1.Make = "Tesla";
        truck1.Model = "CyberTruck";
        truck1.Year = 2022;
        truck1.odometerKM = 50000;

        Console.WriteLine($"Car1\nMake: {car1.Make}\nModel: {car1.Model}\nYear: {car1.Year}\nColor: {car1.color}\n");
        Console.WriteLine($"Truck1\nMake: {truck1.Make}\nModel: {truck1.Model}\nYear: {truck1.Year}\nColor: {truck1.odometerKM}\n");
    }
}