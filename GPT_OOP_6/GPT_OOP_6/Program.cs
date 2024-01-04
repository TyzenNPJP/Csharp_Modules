/*
 * Inheritance: 
 * Create a base class Person with properties Name and Age. 
 * Create a derived class Employee that inherits from Person and has a property Salary. 
 * Create an instance of the Employee class and set its properties. 
 * Print the values of the properties to the console.
*/

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Employee : Person
{
    public int Salary { get; set; }
    public DateTime HireDate { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee person1 = new Employee();
        person1.Name = "Elrond";
        person1.Age = 1000;
        person1.Salary = 3000;
        person1.HireDate = DateTime.Today;

        Console.WriteLine($"Person1\nName: {person1.Name}\nAge: {person1.Age}\nSalary: {person1.Salary}\nHireDate: {person1.HireDate}");
    }
}