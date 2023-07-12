using System;

namespace FinalProgect
{
    class Program
    {
        static void Main(string[] args)
            {
                int option = 1;
                while (option != 0)
                {
                    Console.WriteLine("\nWelcome to Conversion Tracker!\n");
                    Console.WriteLine("People:\nCalanW\nHaleyN\nJohnS\nTimL\nAliceD\nMikeH\n");
                    Console.Write("Please Enter the name of a person: ");
                    string name = Console.ReadLine();

                    if (name == "CalanW" || name == "HaleyN" || name == "JohnS" || name == "TimL" || name == "AliceD" || name == "MikeH")
                    {
                        Menu menu = new Menu();
                        menu.Start(name);
                        option = 0;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a name given!");
                    }
                }
            }
    }
}