using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    internal static class Voting
    {
        public static void Process()
        {
            Console.Write("\t\tEnter the precinct number: ");
            string precinctNumber = Console.ReadLine();
            Console.Clear();

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
            Design.Line();

            Console.Write("\t\tEnter the name of the first candidate: ");
            string cand1 = Console.ReadLine();
            Console.Clear();

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
            Design.Line();
            Console.WriteLine("\t\tNames of Candidates:");
            Console.WriteLine($"\t\tCandidate 1: {cand1}");

            Console.Write("\t\tEnter the name of the second candidate: ");
            string cand2 = Console.ReadLine();
            Console.Clear();

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
            Design.Line();
            Console.WriteLine("\t\tNames of Candidates:");
            Console.WriteLine($"\t\tCandidate 1: {cand1}");
            Console.WriteLine($"\t\tCandidate 2: {cand2}");

            Console.Write("\t\tEnter the name of the third candidate: ");
            string cand3 = Console.ReadLine();
            Console.Clear();

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
            Design.Line();
            Console.WriteLine("\t\tNames of Candidates:");
            Console.WriteLine($"\t\tCandidate 1: {cand1}");
            Console.WriteLine($"\t\tCandidate 2: {cand2}");
            Console.WriteLine($"\t\tCandidate 3: {cand3}");

            Console.Write("\t\tEnter the name of the fourth candidate: ");
            string cand4 = Console.ReadLine();
            Console.Clear();

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
            Design.Line();
            Console.WriteLine("\t\tNames of Candidates:");
            Console.WriteLine($"\t\tCandidate 1: {cand1}");
            Console.WriteLine($"\t\tCandidate 2: {cand2}");
            Console.WriteLine($"\t\tCandidate 3: {cand3}");
            Console.WriteLine($"\t\tCandidate 4: {cand4}");
            Design.Line();

            Console.Write("\t\tEnter the total number of votes you want to count: ");
            int Total_vote = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
            Design.Line();
            Console.WriteLine("\t\tNames of Candidates:");
            Console.WriteLine($"\t\tCandidate 1: {cand1}");
            Console.WriteLine($"\t\tCandidate 2: {cand2}");
            Console.WriteLine($"\t\tCandidate 3: {cand3}");
            Console.WriteLine($"\t\tCandidate 4: {cand4}");
            Design.Line();
            Console.WriteLine($"\t\tTotal Number of Votes: {Total_vote}");
            Design.Line();
            Console.Clear();
            
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int E = 0;

            for (int vote = 1; vote <= Total_vote; vote++)
            {
                Design.Line();
                Greetings.Greet();
                Design.Line();
                Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
                Design.Line();
                Console.WriteLine("\t\tNames of Candidates:");
                Console.WriteLine($"\t\tCandidate 1: {cand1}");
                Console.WriteLine($"\t\tCandidate 2: {cand2}");
                Console.WriteLine($"\t\tCandidate 3: {cand3}");
                Console.WriteLine($"\t\tCandidate 4: {cand4}");
                Design.Line();
                Console.WriteLine($"\t\tTotal Number of Votes: {Total_vote}");
                Design.Line();
                Instructions.Direction();
                Design.Line();

                Console.Write("\t\tEnter your vote: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (choice == 1)
                {
                    A++;
                }
                else if (choice == 2)
                {
                    B++;
                }
                else if (choice == 3)
                {
                    C++;
                }
                else if (choice == 4)
                {
                    D++;
                }
                else
                {
                    E++;
                    Console.WriteLine("Invalid Vote");
                    Console.Clear();

                }
            }
            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
            Design.Line();
            Console.WriteLine("\t\tNames of Candidates:");
            Console.WriteLine($"\t\tCandidate 1: {cand1}");
            Console.WriteLine($"\t\tCandidate 2: {cand2}");
            Console.WriteLine($"\t\tCandidate 3: {cand3}");
            Console.WriteLine($"\t\tCandidate 4: {cand4}");
            Design.Line();
            Console.WriteLine($"\t\tTotal Number of Votes: {Total_vote}");
            Design.Line();
            Instructions.Direction();
            Design.Line();
            Console.WriteLine("\t\tResult of the Votes:");

            if (A <= 1)
            {
                Console.WriteLine($"\t\t{cand1} got {A} vote");
            }
            else
            {
                Console.WriteLine($"\t\t{cand1} got {A} votes");
            }
            if (B <= 1)
            {
                Console.WriteLine($"\t\t{cand2} got {B} vote");
            }
            else
            {
                Console.WriteLine($"\t\t{cand2} got {B} votes");
            }
            if (C <= 1)
            {
                Console.WriteLine($"\t\t{cand3} got {C} vote");
            }
            else
            {
                Console.WriteLine($"\t\t{cand3} got {C} votes");
            }
            if (D <= 1)
            {
                Console.WriteLine($"\t\t{cand4} got {D} vote");
            }
            else
            {
                Console.WriteLine($"\t\t{cand4} got {D} votes");
            }
            Design.Line();

            if (A > B && A > C && A > D)
            {
                Console.WriteLine("\t\tDecision:");
                Console.WriteLine($"\t\t{cand1} win the vote");
                Design.Line();
                Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                Design.Line();
            }
            else if (B > A && B > C && B > D)
            {
                Console.WriteLine("\t\tDecision:");
                Console.WriteLine($"\t\t{cand2} win the vote");
                Design.Line();
                Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                Design.Line();
            }
            else if (C > A && C > B && C > D)
            {
                Console.WriteLine("\t\tDecision:");
                Console.WriteLine($"\t\t{cand3} win the vote");
                Design.Line();
                Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                Design.Line();
            }
            else if (D > A && D > B && D > C)
            {
                Console.WriteLine("\t\tDecision:");
                Console.WriteLine($"\t\t{cand4} win the vote");
                Design.Line();
                Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                Design.Line();
            }
            else
            {
                if (A == B && B == C && C == D)
                {
                    Console.WriteLine("\t\tDecision:");
                    Console.WriteLine("\t\tThe vote result is tied.");
                    Design.Line();
                    Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                    Design.Line();
                }
                else
                {
                    if (A == B && B == C)
                    {
                        Console.WriteLine("\t\tDecision:");
                        Console.WriteLine($"\t\t{cand1}, {cand2}, and {cand3} are tied.");
                        Design.Line();
                        Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                        Design.Line();
                    }
                    else if (A == B && B == D)
                    {
                        Console.WriteLine("\t\tDecision:");
                        Console.WriteLine($"\t\t{cand1}, {cand2}, and {cand4} are tied.");
                        Design.Line();
                        Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                        Design.Line();
                    }
                    else if (B == C && C == D)
                    {
                        Console.WriteLine("\t\tDecision:");
                        Console.WriteLine($"\t\t{cand2}, {cand3}, and {cand4} are tied.");
                        Design.Line();
                        Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                        Design.Line();
                    }
                    else if (C == D && D == A)
                    {
                        Console.WriteLine("\t\tDecision:");
                        Console.WriteLine($"\t\t{cand1}, {cand3}, and {cand4} are tied.");
                        Design.Line();
                        Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                        Design.Line();
                    }
                    else
                    {
                        if (A == B && B != C && B != D && A > C)
                        {
                            Console.WriteLine("\t\tDecision:");
                            Console.WriteLine($"\t\t{cand1} and {cand2} are tied.");
                            Design.Line();
                            Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                            Design.Line();
                        }
                        else if (A == C && C != B && C != D && C > B && C > D)
                        {
                            Console.WriteLine("\t\tDecision:");
                            Console.WriteLine($"\t\t{cand1} and {cand3} are tied.");
                            Design.Line();
                            Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                            Design.Line();
                        }
                        else if (A == D && D != B && D != C && A > B && A > C)
                        {
                            Console.WriteLine("\t\tDecision:");
                            Console.WriteLine($"\t\t{cand1} and {cand4} are tied.");
                            Design.Line();
                            Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                            Design.Line();
                        }
                        else if (B == C && C != D && C != A && B > D && B > A)
                        {
                            Console.WriteLine("\t\tDecision:");
                            Console.WriteLine($"\t\t{cand2} and {cand3} are tied.");
                            Design.Line();
                            Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                            Design.Line();
                        }
                        else if (B == D && D != A && D != C && B > A && B > C)
                        {
                            Console.WriteLine("\t\tDecision:");
                            Console.WriteLine($"\t\t{cand2} and {cand4} are tied.");
                            Design.Line();
                            Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                            Design.Line();
                        }
                        else if (C == D && D != A && D != B && D > A && D > B)
                        {
                            Console.WriteLine("\t\tDecision:");
                            Console.WriteLine($"\t\t{cand3} and {cand4} are tied.");
                            Design.Line();
                            Console.WriteLine($"\t\tInvalid Vote(s): {E}");
                            Design.Line();
                        }
                    }
                }
            }
        }
    }
}
