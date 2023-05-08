using System;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.Store("What is your name?","Matthew Manley","8 May 2023");

            Entry yourEntry = new Entry();
            yourEntry.Store("What is your fav food?","Peanut Butter","8 May 2023");

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);
            journal.StoreEntry(yourEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach(Entry entry in entries)
            {
                string message = entry.GetAsString();
                Console.WriteLine(message);
            }
        }
    }
}