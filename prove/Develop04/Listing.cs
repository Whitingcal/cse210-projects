using System;

namespace Develop04
{
    public class Listing:Activity
    {
        public Listing():base("Listing","This activity will help guide you to think broadly,\nby helping you list as many things as they can in a certain area of strength or positivity.\nYou might discover more breadth than you previously realized.")
        {

        }

        private List<string> countList = new List<string>();

        private string[] listingList = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        private int count = 0;

        public void StartListing()
        {
            Random random = new Random();
            int promptIndex = random.Next(0, 4);
            
            Console.WriteLine($"{listingList[promptIndex]}\n");
            Thread.Sleep(10000);

            Console.WriteLine("Get Ready!");
            Thread.Sleep(1500);
            Console.WriteLine("And...");
            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine($"{listingList[promptIndex]}");

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(20);
            DateTime currentTime = DateTime.Now;
            
            while (futureTime >= currentTime)
            {
                countList.Add(Console.ReadLine());
                currentTime = DateTime.Now;
            }

            foreach (string item in countList)
            {
                count += 1;
            }

            Console.WriteLine($"You listed {count} items!\n");
            Thread.Sleep(3000);
        }
    }
}