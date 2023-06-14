using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "";

            while (menu != "0")
            {
                Console.Write("Welcome to the Mindfulness Activity!\nPlease choose which activity you would like:\n    1: Breathing Activity\n    2: Reflection Activity\n    3: Listing Activity\n    0: Quit\n");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.Clear();
                    Breathing breathing = new Breathing();
                    Console.WriteLine($"You chose the {breathing.GetActivity()} activity!");
                    Thread.Sleep(2000);

                    Console.WriteLine($"{breathing.GetMessage()}");
                    Thread.Sleep(5000);
                    Console.Clear();

                    breathing.StartBreathing();

                    Console.WriteLine("Great Job! I hope you now feel more relaxed!\n");
                    Thread.Sleep(2500);

                    menu = "0";
                }

                if (menu == "2")
                {
                    Console.Clear();
                    Reflection reflection = new Reflection();

                    Console.WriteLine($"You chose the {reflection.GetActivity()} activity!");
                    Thread.Sleep(2000);

                    Console.WriteLine($"{reflection.GetMessage()}");
                    Thread.Sleep(5000);
                    Console.Clear();

                    reflection.StartReflection();

                    Console.WriteLine("Great Job! I hope you now feel more thoughtful!\n");
                    Thread.Sleep(2500);
                    
                    menu = "0";
                }

                if (menu == "3")
                {
                    Console.Clear();
                    Listing listing = new Listing();

                    Console.WriteLine($"You chose the {listing.GetActivity()} activity!");
                    Thread.Sleep(2000);

                    Console.WriteLine($"{listing.GetMessage()}");
                    Thread.Sleep(5000);
                    Console.Clear();

                    Console.WriteLine($"You will have 10 seconds to read the propt and think about how to respond.\nThen, when told, you'll have 20 seconds to write down your responses.\n");
                    Thread.Sleep(10000);

                    listing.StartListing();

                    Console.WriteLine("Great Job! I hope you now feel more positive!\n");
                    Thread.Sleep(2500);

                    menu = "0";
                }

                Console.Clear();
                Console.WriteLine($"\nThank you for being mindful! Have a great day!\n");
            }
        }
    }
}