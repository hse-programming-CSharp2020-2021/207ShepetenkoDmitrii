using System;

namespace Task3
{

    class VetoVoter
    {
        string Name { get; set; }

    }
    class VetoComission
    {
        EventHandler<VetoEventArgs> OnVote;
        public VetoEventArgs Vote(string Proposal)
        {
            EventHandler<VetoEventArgs v+=
        }
    }
    class VetoEventArgs : EventArgs 
    {
        string Proposal { get; set; }
        VetoVoter VetoBy { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
