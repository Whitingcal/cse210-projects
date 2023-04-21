using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letter = "";

        Console.Write("What is your grade percentage? ");
        string sgrade = Console.ReadLine();

        grade = Convert.ToInt32(sgrade);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade >= 0 && grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Try entering it again.");
        }

        Console.WriteLine($"Your grade for the class is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congradulations, you passed!");
        }
        else if (grade < 70 && grade is >= 0)
        {
            Console.WriteLine("Its ok, you can always try again!");
        }
        else
        {
            Console.WriteLine();
        }
    }
}