using System.Collections.Generic;

namespace Develop02
{
    ///The respsnsibility of a Journal is to store Entries

    public class Journal
    {
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public List<Entry> GetAllEntries()
        {
            return entries;
        }

        public void StoreEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }
    }
}