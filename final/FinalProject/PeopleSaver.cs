using System;

namespace FinalProgect
{
    class PeopleSaver
    {
        // Save people
        public void SavePeople(Person person)
        {
            string name = person.GetName();
            string age = person.GetAge();
            File.AppendAllText("people.txt", $"{name}|{age}");
        }

        // Save Lessons
        public void SaveLesson(Person person, LessonEvent lesson)
        {
            string name = person.GetName();
            File.AppendAllText("lessons.txt", $"{name}|{lesson.ToString()}\n");
        }

        // Save Invitations
        public void SaveInvitation(Person person, InvitationEvent invitation)
        {
            string name = person.GetName();
            File.AppendAllText("invitations.txt", $"{name}|{invitation.ToString()}\n");
        }

        // Save Ordinances
        public void SaveOrdinance(Person person, OrdinanceEvent ordinance)
        {
            string name = person.GetName();
                File.AppendAllText("ordinances.txt", $"{name}|{ordinance.ToString()}\n");
        }
    }
}