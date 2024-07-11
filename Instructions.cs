using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    internal static class Instructions
    {
        public static void Note()
        {
            Console.WriteLine("\t\tNOTE: This voting system only allow 4 candidates!");
        }

        public static void Direction()
        {
            Console.WriteLine("\t\tInstruction:");
            Console.WriteLine($"\t\tEnter 1 to vote for Candidate A");
            Console.WriteLine($"\t\tEnter 2 to vote for Candidate B");
            Console.WriteLine($"\t\tEnter 3 to vote for Candidate C");
            Console.WriteLine($"\t\tEnter 4 to vote for Candidate D");
        }
    }
}
