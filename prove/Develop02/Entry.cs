namespace Develop02
{
    ///The respsnsibility of an Entry is to record (or store) a prompt, response, and date.

    public class Entry
    {
        public string prompt;
        public string response;
        public string date;

        public string GetAsString()
        {
            return $"{date}\n{prompt}\n{response}\n";
        }

        public List<string> GetAsList()
        {
            List<string> data = new List<string>();
            data.Add(prompt);
            data.Add(response);
            data.Add(date);
            
            return data;
        }

        public void Store(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
    }
}