using System;

namespace FinalProgect
{
    class PeopleLoader
    {
        private string age = "";
        private DateTime date;
        private List<LessonEvent> lessons = new List<LessonEvent>();
        private List<InvitationEvent> invitations = new List<InvitationEvent>();
        private List<OrdinanceEvent> ordinances = new List<OrdinanceEvent>();
        private LessonEvent lesson;
        private InvitationEvent invitation;
        private OrdinanceEvent ordinance;

        public Person Load(string name)
        {
            // Load people
            foreach (string line in File.ReadLines("people.txt"))
            {
                if (line.Contains(name))
                {
                    string [] lineS = line.Split("|");
                    age = lineS[1];

                }
            }

            Person person = new Person(name, age, lessons, invitations, ordinances);

            // Load Lessons
            foreach (string line in File.ReadLines("lessons.txt"))
            {
                if (line.Contains(name))
                {
                    string [] lineS = line.Split("|");
                    date = DateTime.Parse(lineS[1]);
                    lesson = new LessonEvent(date, lineS[2]);
                    person.Record(lesson);
                }
            }

            // Load Invitations
            foreach (string line in File.ReadLines("invitations.txt"))
            {
                if (line.Contains(name))
                {
                    string [] lineS = line.Split("|");
                    date = DateTime.Parse(lineS[1]);
                    invitation = new InvitationEvent(date, lineS[2]);
                    person.Record(invitation);
                }
            }

            // Load Ordinances
            foreach (string line in File.ReadLines("ordinances.txt"))
            {
                if (line.Contains(name))
                {
                    string [] lineS = line.Split("|");
                    date = DateTime.Parse(lineS[1]);
                    ordinance = new OrdinanceEvent(date, lineS[2]);
                    person.Record(ordinance);
                }
            }
            return person;
        }

        //Lines will look like this: "[name]|[age]" and so on
    }
}