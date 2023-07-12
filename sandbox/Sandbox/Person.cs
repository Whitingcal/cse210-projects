using System;

namespace Sandbox
{
    public class Person
    {
        public string Name { get; set; }
        public List<string> LessonsTaught { get; set; }
        public List<string> CommitmentsKept { get; set; }
        public List<string> OrdinancesReceived { get; set; }

        public Person(string name)
        {
            Name = name;
            LessonsTaught = new List<string>();
            CommitmentsKept = new List<string>();
            OrdinancesReceived = new List<string>();
        }
    }
}