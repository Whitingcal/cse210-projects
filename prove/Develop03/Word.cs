using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Word
    {
        private string oringinalChar;
        private string currentChar;

        public Word(string characters)
        {
            oringinalChar = characters;
            currentChar = characters;
        }
        public void Hide()
        {
            currentChar = "";
            for(int counter = 0; counter < oringinalChar.Length; counter++)
            {
                /// if (originalChar != 1-100)
                currentChar += "_";
            }
        }

        public void Show()
        {
            currentChar = oringinalChar;
        }

        public string AsString()
        {
            return currentChar;
        }
    }
}