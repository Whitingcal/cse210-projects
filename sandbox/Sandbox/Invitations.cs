using System;

namespace Sandbox
{
    class Invitations : Visit
    {
        private List<string> invitations;

        public Invitations(List<string> invitations)
        {
            this.invitations = invitations;
        }

        public void ExtendInvitation(string invitation)
        {
            invitations.Add(invitation);
        }

        public override void MarkOff()
        {
            Console.WriteLine("Invitation extended marked off.");
        }
        }
}