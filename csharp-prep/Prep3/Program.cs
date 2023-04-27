using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringResponce = "a";
            int responce = 0;

            // Console.Write("What is the magic number? ");
            // string stringMagicNum = Console.ReadLine();

            //int magicNum = Convert.ToInt32(stringMagicNum);

            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 11);

            do
            {
                Console.Write("What is your guess? ");
                stringResponce = Console.ReadLine();

                responce = Convert.ToInt32(stringResponce);

                if (responce < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (responce > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (responce == magicNum)
                {
                    Console.WriteLine("Thats it!");
                }
                else
                {
                    Console.WriteLine("How'd you do that?");
                }

            } while (responce != magicNum);
        }
    } 
}