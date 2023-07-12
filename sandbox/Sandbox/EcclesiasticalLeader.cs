using System;

namespace Sandbox
{
    class EcclesiasticalLeader
    {
        public bool IsReadyForOrdinance(Person person, Lessons lessons)
        {
            foreach (string principle in lessons.PrinciplesTaught)
            {
                if (!person.LessonsTaught.Contains(principle))
                    return false;
            }

            foreach (string commitment in person.CommitmentsKept)
            {
                if (!lessons.PrinciplesTaught.Contains(commitment))
                    return false;
            }

            return true;
        }
    }
}