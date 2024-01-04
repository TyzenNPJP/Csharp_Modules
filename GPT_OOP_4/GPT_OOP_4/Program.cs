/*
 *  Polymorphism
 *  Create a class Shape with a method Draw(). 
 *  Create two derived classes Circle and Rectangle that inherit from Shape. 
 *  Override the Draw() method in each derived class to draw a different shape. 
 *  Create an array of Shape objects that contains one instance of each derived class. 
 *  Call the Draw() method on each object in the array.
*/

// A base class which can be used for a basic type to iterate on a collection
// Layout necessary members
public abstract class Shape
{
    public abstract void Draw();

    public void Shade()
    {
        Console.WriteLine("Shady");
    }
}

// Override necessary members
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Its a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Its a rectangle");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rect = new Rectangle();

        // Create objects of base type
        Shape[] array_shape = new Shape[2];
        array_shape[0] = circle;
        array_shape[1] = rect;

        // Iterate on collection
        foreach (Shape obj in array_shape)
        {
            obj.Draw();
        }
    }
}