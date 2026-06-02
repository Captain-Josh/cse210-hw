using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Nweke Joshua", "Multiplication");
        assignment.GetSummary();
        Console.WriteLine();

        MathAssignment assignment1 = new MathAssignment("Nweke Joshua", "Fraction", "7.3", "8-18");
        assignment1.GetSummary();
        assignment1.GetHomeworkList();
        Console.WriteLine();


        WritingAssignment assignment2 = new WritingAssignment("Nweke Joshua", "European History", "The causes of World War II by Mary Waters");
        assignment2.GetSummary();
        assignment2.GetWritingInformation();
    }
}