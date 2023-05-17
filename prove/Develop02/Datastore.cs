using System;
using System.Collections.Generic;


namespace Develop02
{
    ///The respsnsibility of a Datastore is to save and load Entries

    public class Datastore
    {
        public Journal Load(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);

            Journal journal = new Journal();

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                ///create a new entry
                Entry myEntry = new Entry();
                ///store resp, prompt, and date in the entry
                myEntry.Store(prompt, response, date);
                ///add entry to journal
                journal.StoreEntry(myEntry);
            }
            ///return the journal
            return journal;
        }
        public void Save(Journal journal, string file)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                List<Entry> entries = journal.GetAllEntries();
                foreach(Entry entry in entries)
                {
                    List<string> message = entry.GetAsList();

                    string date = message[2];
                    string prompt = message[0];
                    string response = message[1];
                    ///take the list elements and make a comma seperated string out of them
                    string savableEntry = $"{date}|{prompt}|{response}";

                    //store into a new line in the file
                    outputFile.WriteLine(savableEntry);
                }
            }
        }
    }
}