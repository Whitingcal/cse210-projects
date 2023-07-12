using System;

namespace FinalProgect
{
    public class Menu
    {
        private string option;
        private string choice;
        private LessonEvent lesson;
        private InvitationEvent invitation;
        private OrdinanceEvent ordinance;
        private PeopleSaver saver = new PeopleSaver();
        public void Start(string personName) 
        {
            PeopleLoader loader = new PeopleLoader();
            Person person = loader.Load(personName);

            while (option != "4")
            {
                person.Display();

                Console.Write("\nChoose one of the following:\n  1. Record Lesson Taught\n  2. Record Invitations Accepted\n  3. Record Ordinance Made\n  4. Quit\nYour Choice: ");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Write("\nWhat Lesson did you teach?\n  1. The Restoration\n  2. The Plan of Salvation\n  3. The Gospel of Jesus Christ\n  4. The Commandments\n  5. The Laws and Ordinances\n  6. Back\n Your choice: ");
                    choice = Console.ReadLine();
                    // Record Lesson Taught
                    while (choice != "6")
                    {
                        if (choice == "1")
                        {
                            lesson = new LessonEvent(DateTime.Now, "The Restoration");
                            person.Record(lesson);
                            saver.SaveLesson(person, lesson);
                        }
                        else if (choice == "2")
                        {
                            lesson = new LessonEvent(DateTime.Now, "The Plan of Salvation");
                            person.Record(lesson);
                            saver.SaveLesson(person, lesson);
                        }
                        else if (choice == "3")
                        {
                            lesson = new LessonEvent(DateTime.Now, "The Gospel of Jesus Christ");
                            person.Record(lesson);
                            saver.SaveLesson(person, lesson);
                        }
                        else if (choice == "4")
                        {
                            lesson = new LessonEvent(DateTime.Now, "The Commandments");
                            person.Record(lesson);
                            saver.SaveLesson(person, lesson);
                        }
                        else if (choice == "5")
                        {
                            lesson = new LessonEvent(DateTime.Now, "The Laws and Ordinances");
                            person.Record(lesson);
                            saver.SaveLesson(person, lesson);
                        }
                        else
                        {
                            Console.WriteLine("Please choose from 1-6.");
                        }
                        choice = "6";
                    }
                }

                else if (option == "2")
                {
                    Console.Write("\nWhat Invitation was accepted?\n  1. Read the Scriptures\n  2. Come to Church\n  3. Be Baptized\n  4. Back\n Your choice: ");
                    choice = Console.ReadLine();
                    // Record Invitations Accepted
                    while (choice != "4")
                    {   
                        if (choice == "1")
                        {
                            invitation = new InvitationEvent(DateTime.Now, "Read the Scriptures");
                            person.Record(invitation);
                            saver.SaveInvitation(person, invitation);
                        }
                        else if (choice == "2")
                        {
                            invitation = new InvitationEvent(DateTime.Now, "Come to Church");
                            person.Record(invitation);
                            saver.SaveInvitation(person, invitation);
                        }
                        else if (choice == "3")
                        {
                            invitation = new InvitationEvent(DateTime.Now, "Be Baptized");
                            person.Record(invitation);
                            saver.SaveInvitation(person, invitation);
                        }
                        else
                        {
                            Console.WriteLine("Please choose from 1-4.");
                        }
                        choice = "4";
                    }
                }

                else if (option == "3")
                {
                    Console.Write("\nWhat Ordinance was made?\n  1. Baptism\n  2. Endowment\n  3. Sealing\n  4. Back\n Your choice: ");
                    choice = Console.ReadLine();
                    // Record Ordinance Made
                    while (choice != "4")
                    {    
                        if (choice == "1")
                        {
                            ordinance = new OrdinanceEvent(DateTime.Now, "Baptism");
                            person.Record(ordinance);
                            saver.SaveOrdinance(person, ordinance);
                        }
                        else if (choice == "2")
                        {
                            ordinance = new OrdinanceEvent(DateTime.Now, "Endowment");
                            person.Record(ordinance);
                            saver.SaveOrdinance(person, ordinance);
                        }
                        else if (choice == "3")
                        {
                            ordinance = new OrdinanceEvent(DateTime.Now, "Sealing");
                            person.Record(ordinance);
                            saver.SaveOrdinance(person, ordinance);
                        }
                        else
                        {
                            Console.WriteLine("Please choose from 1-4.");
                        }
                        choice = "4";
                    }
                }
            }
        }
    }
}