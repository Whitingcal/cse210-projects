using System;

namespace Develop03
{
    public class Scripture
    {
        private string reference;

        private List<Word> list = new List<Word>();

        public Scripture(string reference, List<Word> words)
        {
            list = words;
            this.reference = reference;
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, list.Count - 1);
            Word word = list[index];
            word.Hide();
        }

        public string AsString()
        {
            string text = $"{reference}\n";

            foreach (Word word in list)
            {
                text += word.AsString() + " ";
            }

            return text;
        }
    }
}