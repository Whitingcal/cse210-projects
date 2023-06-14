using System;

namespace Develop04
{
    public class Reflection:Activity
    {
        private string[] reflectionPromptList = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

        private string[] reflectionQuestionList = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?}"};

        public Reflection():base("Reflection","This activity will guide you to think deeply, by having you consider a certain experience when you were successful or demonstrated strength.\nThen, you will be prompted with questions to reflect more deeply about the details of this experience.\nYou might discover more depth than you previously realized.")
        {

        }

        public void StartReflection()
        {
            Random random = new Random();
            int promptIndex = random.Next(0, 3);
            int questionIndex = random.Next(0, 8);
            int questionIndex2 = random.Next(0, 8);

            Console.WriteLine("Get Ready!");
            Thread.Sleep(1500);
            Console.WriteLine("And...");
            Thread.Sleep(1500);
            Console.Clear();
            int end = 0;

            Console.WriteLine($"{reflectionPromptList[promptIndex]}");

            RunTimer();
            RunTimer();
            RunTimer();
            RunTimer();
            RunTimer();
            RunTimer();

            Console.WriteLine($"\n{reflectionQuestionList[questionIndex]}");

            RunTimer();
            RunTimer();
            RunTimer();
            RunTimer();
            RunTimer();
            RunTimer();

            while (end != 1)
            {
                if (questionIndex != questionIndex2)
                {
                    Console.WriteLine($"\n{reflectionQuestionList[questionIndex2]}");

                    RunTimer();
                    RunTimer();
                    RunTimer();
                    RunTimer();
                    RunTimer();
                    RunTimer();
                    
                    end = 1;
                }
                else
                {
                    questionIndex2 = random.Next(0, 8);
                }
            }
        }
    }
}