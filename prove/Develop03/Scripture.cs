using System;

namespace Develop03
{
    public class Scripture
    {
        private string reference;
        /// List<Word>
        private List<Word> list = new List<Word>();

        /// Scripture(List<word>)
        public Scripture(string reference, List<Word> words)
        {
            list = words;
            this.reference = reference;
        }

        /// HideRandomWord()
        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, list.Count - 1);
            Word word = list[index];
            word.Hide();
        }

        /// AsString()
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