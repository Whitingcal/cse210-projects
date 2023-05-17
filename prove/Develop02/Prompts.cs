/// generate prompts

namespace Develop02
{
    ///The respsnsibility of a Prompts is to randomly pull a prompt from a bank of prompts

    public class Prompts
    {
        public string GetRandomPrompt()
        {
        ///make a list of prompts
        List<string> promptBank = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};

        ///generate a random number within the index range of the prompts list (5 total)
        Random num = new Random();
        int index = num.Next(0, 4);

        ///pull a prompt from the bank using the randomly generated index
        string prompt = promptBank[index];

        return prompt;
        }
    }
}