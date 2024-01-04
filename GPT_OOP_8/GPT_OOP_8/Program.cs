/*
 * Interfaces: 
 * Create an interface IShape with methods GetArea() and GetPerimeter(). 
 * Create two classes Circle and Rectangle that implement the IShape interface. 
 * Implement the GetArea() and GetPerimeter() methods in each class to calculate the area and perimeter of the shape. 
 * Create an instance of each class and call their GetArea() and GetPerimeter() methods.
*/

// Interface Members must be implemented in the sub class
public interface IShape
{
    string Name { get; set; }

    public void GetArea();
    public void GetPerimeter();
}

public class Circle : IShape
{
    public string Name { get; set; }
    public int r { get; set; }

    public void GetArea()
    {
        Console.WriteLine("Circle Area: " + Math.PI * r * r);
    }

    public void GetPerimeter()
    {
        Console.WriteLine("Circle Perimeter: " + 2 * Math.PI * r);
    }
}

public class Rectangle : IShape
{
    public string Name { get; set; }
    public int l { get; set; }
    public int b { get; set; }

    public void GetArea()
    {
        Console.WriteLine("Rectangle Area: " + l * b);
    }

    public void GetPerimeter()
    {
        Console.WriteLine("Rectangle Perimeter: " + 2 * (l+b));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.r = 5;

        circle.GetArea();
        circle.GetPerimeter();

        Rectangle rectangle = new Rectangle();
        rectangle.l = 5;
        rectangle.b = 10;

        rectangle.GetArea();
        rectangle.GetPerimeter();
    }
}