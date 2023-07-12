using System;

namespace FinalProgect
{
    public class Person
    {
        private string _name = "";
        private string _age = "";
        private List<LessonEvent> _lessons = new List<LessonEvent>();
        private List<InvitationEvent> _invitations = new List<InvitationEvent>();
        private List<OrdinanceEvent> _ordinances = new List<OrdinanceEvent>();



        public Person(string name, string age, List<LessonEvent> lessons, List<InvitationEvent> invitations, List<OrdinanceEvent> ordinances)
        {
            _name = name;
            _age = age;
            _lessons = lessons;
            _invitations = invitations;
            _ordinances = ordinances;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAge()
        {
            return _age;
        }

        public List<LessonEvent> GetLessons()
        {
            return _lessons;
        }

        public List<InvitationEvent> GetInvitations()
        {
            return _invitations;
        }

        public List<OrdinanceEvent> GetOrdinance()
        {
            return _ordinances;
        }

        public void Record(OrdinanceEvent ordinance)
        {
            _ordinances.Add(ordinance);
        }

        public void Record(LessonEvent lesson)
        {
            _lessons.Add(lesson);
        }

        public void Record(InvitationEvent invitation)
        {
            _invitations.Add(invitation);
        }
        public void Display()
        {
            Console.WriteLine($"\nName: {_name}\nAge: {_age}");
            Console.WriteLine("Lessons Taught:");
            foreach (LessonEvent displayLesson in _lessons)
            {
                Console.WriteLine($"{displayLesson}");
            }
            Console.WriteLine("Invitations Extended:");
            foreach (InvitationEvent displayInvitation in _invitations)
            {
                Console.WriteLine($"{displayInvitation}");
            }
            Console.WriteLine("Ordinances Completed:");
            foreach (OrdinanceEvent displayOrdinance in _ordinances)
            {
                Console.WriteLine($"{displayOrdinance}");
            }
        }
    }
}