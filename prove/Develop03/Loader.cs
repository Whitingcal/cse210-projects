using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Loader
    {
        /// Create dictionary with scripture references, example: Dict<reference, content>
        Dictionary<string, string> scriptureDict = new Dictionary<string, string>();
        
        public Loader()
        {
            scriptureDict["John 3:16"] = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

            scriptureDict["Proverbs 3:5-6"] = "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.";

            ///scriptureDict[""] = "";

            ///scriptureDict[""] = "";
        }

        /// FindRandomScripture()
        public Scripture FindRandomScripture()
        {
            List<string> keys = new List<string>(scriptureDict.Keys);

            Random random = new Random();
            int index = random.Next(0, keys.Count);
            string key = keys[index];

            string text = scriptureDict[key];

            string[] splitText = text.Split(" ");
            List<Word> words = new List<Word>();

            foreach (string wordText in splitText)
            {
                Word word = new Word(wordText);

                words.Add(word);
            }

            Scripture scripture = new Scripture(key, words);

            return scripture;
        }
    }
}