/*
 * Encapsulation: 
 * Create a class Student with properties Name, LetterGrade, and Major. 
 * Create a method GetGPA() that returns the GPA based on the LetterGrade property. 
 * Make the LetterGrade property read-only. 
 * Create an instance of the Student class and call its GetGPA() method. 
*/

public class Student
{
    public string Name { get; set; }
    public readonly char Letter_Grade = 'A';
    public string Major { get; set; }

    public float GetGPA(char Letter_Grade)
    {
        switch (Letter_Grade)
        {
            case 'A':
                return 4;

            case 'B':
                return 3.5f;

            case 'C':
                return 3f;

            case 'D':
                return 2.5f;

            case 'E':
                return 2f;

            default:
                return 0;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Major = "Science";
        student.Name = "Faramir";
        float GPA = student.GetGPA(student.Letter_Grade);
        Console.WriteLine($"Student\nName: {student.Name}\nMajor: {student.Major}\nGPA: {GPA}");
    }
}
