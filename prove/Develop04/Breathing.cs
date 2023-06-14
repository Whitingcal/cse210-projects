using System;

namespace Develop04
{
    public class Breathing:Activity
    {
        public Breathing():base("Breathing","This activity will help you pace your breathing by a series of deep inhales and exhales for a certain amount of time.\nYou might find more peace and less stress through this exercise.")
        {

        }

        public void StartBreathing()
        {
            Console.WriteLine("Get Ready!");
            Thread.Sleep(1500);
            Console.WriteLine("And...");
            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine("Breath in...");
            RunTimer();
            Console.Clear();
            Console.WriteLine("Breath out...");
            RunTimer();
            Console.Clear();

            Console.WriteLine("Breath in...");
            RunTimer();
            Console.Clear();
            Console.WriteLine("Breath out...");
            RunTimer();
            Console.Clear();

            Console.WriteLine("Breath in...");
            RunTimer();
            Console.Clear();
            Console.WriteLine("Breath out...");
            RunTimer();
            Console.Clear();
        }
    }
}