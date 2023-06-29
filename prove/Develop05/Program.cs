using System;
using System.Collections.Generic;

namespace Develop05 {
    class Program {
        static void Main(string[] args) {
            User user = new User("goals.txt");
            
            string input = "";

            do 
            {
                Console.WriteLine($"You have {user.GetTotalScore()} points.");
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Record Goal Completion");
                Console.WriteLine("  4. Quit");

                Console.Write("Your Choice: ");
                input = Console.ReadLine();
                Console.WriteLine();

                switch (input) 
                {
                    case "1":
                        user.CreateGoal();
                        break;
                    case "2":
                        user.DisplayGoals();
                        break;
                    case "3":
                        user.CompleteGoal();
                        break;
                }

            } while (new List<String>(){"1", "2", "3"}.Contains(input));

            user.WriteToFile();
            
        }
    }
}

