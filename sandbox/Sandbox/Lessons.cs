using System;

namespace Sandbox
{
    class Lessons : Visit
    {
        private List<string> principles;

        public Lessons(List<string> principles)
        {
            this.principles = principles;
        }

        public void AddPrinciple(string principle)
        {
            principles.Add(principle);
        }

        public override void MarkOff()
        {
            Console.WriteLine("Principle taught marked off.");
        }

        public List<string> Principles()
        {
            return principles;
        }
    }
}