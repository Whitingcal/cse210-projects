using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Loader loader = new Loader();

            Scripture scripture = loader.FindRandomScripture();

            string option = "";

            Console.WriteLine($"\nWelcome to scripture memorizer! Type 'Quit' to exit. Press any button to hide one word at a time.\n");

            while (option != "Quit")
            {
                Console.Write($"Type 'Quit' to exit\n\n{scripture.AsString()}\n");
                option = Console.ReadLine();

                scripture.HideRandomWord();
                Console.Clear();
            }
        }
    }
}