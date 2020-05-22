using System;

namespace PaperRockScissors
{
    class Program
    {
        enum Choice
        {
            Paper = 1,
            Rock = 2,
            Scissors = 3
        }


        static void Main(string[] args)
        {
            Random rndChoice = new Random();

            Console.WriteLine("This is \"Rock, paper, scissors \" game.");
            Console.WriteLine("(1) - Paper");
            Console.WriteLine("(2) - Rock");
            Console.WriteLine("(3) - Scissors");
            Console.WriteLine("Make a choice : ");

            int userInput = int.Parse(Console.ReadLine());
            var computerInput = (Choice)rndChoice.Next(1, 4);

            Console.WriteLine($"Your choice : {(Choice)userInput}");
            Console.WriteLine($"Computer choice : {computerInput}");
        }
    }
}
