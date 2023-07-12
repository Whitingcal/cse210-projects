using System;

namespace Sandbox
{
    class Ordinances : Visit
    {
        private List<string> ordinances;

        public Ordinances(List<string> ordinances)
        {
            this.ordinances = ordinances;
        }

        public void AddOrdinance(string ordinance)
        {
            ordinances.Add(ordinance);
        }

        public override void MarkOff()
        {
            Console.WriteLine("Ordinance completed marked off.");
        }
    }
}