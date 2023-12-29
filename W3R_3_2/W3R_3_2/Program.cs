/*
 * Write a C# program to implement a method that takes an integer as input and throws an exception if the number is negative. 
 * Handle the exception in the calling code.
 * Throw exception if the number is of type float.
 * Throw exception if the number is more than 100.
 * 
 *  --- Custom made exceptions ---
*/

class Program
{
    static void Function()
    {
        Console.WriteLine("Enter a positive integer: ");

        // Try implementing code
        try
        {
            int num = Convert.ToInt32(Console.ReadLine());

            // Throw exceptions for certain condition
            if (num < 0)
            {
                throw new Negative_Number_Exception("Error: Negative number unacceptable. Please try again!");
            }
            if (num.GetType() == typeof(float))
            {
                throw new Float_Number_Exception("Error: The entered number is of invalid type (float).");
            }
            if (num > 100)
            {
                throw new Exceed_Hundred_Exception("Error: Entered number is more than hundred.");
            }
        }

        // Catch irregularities
        catch (Negative_Number_Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Float_Number_Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exceed_Hundred_Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void Main(string[] args)
    {
        Function();
    }
}

// Custom-Made Exceptions
class Negative_Number_Exception : Exception
{
    public Negative_Number_Exception(string message) : base(message) { }
}

class Float_Number_Exception: Exception
{
    public Float_Number_Exception(string message) : base(message) { }
}

class Exceed_Hundred_Exception: Exception
{
    public Exceed_Hundred_Exception(string message) : base(message) { }
}