using System;
using System.Collections.Generic;

namespace Voting_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Design.Line();
            Greetings.Greet();
            Design.Line();
            Instructions.Note();
            Design.Line();
            Voting.Process();
            Greetings.Thanks();
            Design.Line();
        }


    }
}