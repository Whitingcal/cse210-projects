using System;

class Program
{
    static void Main(string[] args)
    {
        int responce = 1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (responce != 0)
        {
            Console.Write("Add a number: ");
            string stringResponce = Console.ReadLine();
            responce = Convert.ToInt32(stringResponce);

            if (responce != 0)
            {
                numbers.Add(responce);
            }
        }

        int sum = numbers.Sum();
        int count = numbers.Count();
        int average = sum / count;
        int max = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"The largesnt number is: {max}");
        
    }
}