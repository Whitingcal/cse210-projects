using System;

namespace Sandbox
{
    class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("1. Mark a principle taught");
            Console.WriteLine("2. Mark an invitation extended");
            Console.WriteLine("3. Mark an ordinance complete");
            Console.WriteLine("4. Exit");

            int choice;
            do
            {
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Mark a principle taught
                        Lessons lessons = new Lessons(new List<string>());
                        lessons.MarkOff();
                        break;
                    case 2:
                        // Mark an invitation extended
                        Invitations invitations = new Invitations(new List<string>());
                        invitations.MarkOff();
                        break;
                    case 3:
                        // Mark an ordinance complete
                        Ordinances ordinances = new Ordinances(new List<string>());
                        ordinances.MarkOff();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4);
        }
    }
}