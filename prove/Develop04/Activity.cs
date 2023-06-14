using System;

namespace Develop04
{
    public class Activity
    {
        private string _activity = "";
        private string _message = "";

        public Activity(string activity, string message)
        {
            _activity = activity;
            _message = message;
        }
        

        public string GetActivity()
        {
            return _activity;
        }

        public string GetMessage()
        {
            return _message;
        }
        
        public void RunTimer()
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}