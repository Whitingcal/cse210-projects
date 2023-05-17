using System;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ask user for a filename
            Console.Write("Please enter the [name.txt] of your file. ");
            string file = Console.ReadLine();

            ///load journal using the file name
            Datastore datastore = new Datastore();
            Journal journal = datastore.Load(file);

            string option = "1";

            ///start the program loop
            while(option != "0")
            {
                ///menu, Ask user to choose from menu
                Console.Write($"Welcome to your Journal. Please select from the following:\n1. New Entry\n2. Display Journal\n3. Delete Entry (not working)\n0. Quit\n");
                option = Console.ReadLine();

                ///if 1 then
                if(option == "1")
                {
                    ///pull date
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    ///pull prompt
                    Prompts prompts = new Prompts();
                    string prompt = prompts.GetRandomPrompt();

                    ///ask prompt
                    Console.Write($"{prompt}\n");
                    string response = Console.ReadLine();

                    Entry entry = new Entry();

                    entry.Store(prompt, response, dateText);
                    ///save response
                    journal.StoreEntry(entry);
                }

                else if(option == "2")
                {
                    ///display every journal entry
                    List<Entry> entries = journal.GetAllEntries();
                    foreach(Entry entry in entries)
                    {
                        string message = entry.GetAsString();
                        Console.WriteLine($"\n{message}");
                    }
                }

                else if(option == "3")
                {
                    ///I don't actually want to do this but thought it would be fun to add.
                    Console.WriteLine("This function does not work, so enjoy the other functions of a program");
                }
                
                else if(option == "0")
                {
                    Console.WriteLine("Thank you, have a nice day!");
                }

                if(option != "0")
                {
                    ///store and save entry with response, prompt, and date
                    Datastore ds = new Datastore();
                    ds.Save(journal,file);
                }
            }
        }
    }
}