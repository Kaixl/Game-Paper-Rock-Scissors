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

            string userInput = Console.ReadLine();
            var computerInput = (Choice)rndChoice.Next(1, 4);

            bool check = false;
            

            //  WYJĄKI
            try
            {
                int user = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your choice is not an integer!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose the one of the option from the menu above.");
                Console.ForegroundColor = ConsoleColor.White;
                check = true;
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your argument is out of range.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose the one of the option from the menu above.");
                Console.ForegroundColor = ConsoleColor.White;
                check = true;
            }
            
            if(check == true)
            {
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine($"Your choice : {(Choice)int.Parse(userInput)}");
                Console.WriteLine($"Computer choice : {computerInput}");
            }            


        }
    }
}
