using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Calan Whiting", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Haley Newman", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetMathInfo());

        WritingAssignment assignment3 = new WritingAssignment("Zach Larson", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}