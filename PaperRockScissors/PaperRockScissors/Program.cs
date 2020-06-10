using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace PaperRockScissors
{
    class Program
    {       
        static void Main(string[] args)
        {
            Game gra = new Game();

            bool check = false;
            do
            {
                gra.Play();
                if (gra.winner == true)
                {
                    Console.WriteLine("Do you wanna play again? (Y)es || (N)o");
                    string response = Console.ReadLine().ToUpper();

                    while(check == false)
                    {
                        if (response != "Y" && response != "N")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You entered invalid input. Please choose \"Y\" for Yes or \"N\" for No.");
                            Console.ForegroundColor = ConsoleColor.White;
                            response = Console.ReadLine().ToUpper();
                            check = false;
                        }
                        else
                        {
                            check = true;
                        }
                    }

                    if (response == "Y")
                    {
                        gra.winner = false;
                        Console.Clear();
                        gra.userScore = 0;
                        gra.computerScore = 0;
                        check = false;
                    }
                    else if (response == "N")
                    {
                        break;
                    }                    
                }
            } while (!gra.winner);


            /*
            Random rndChoice = new Random();

            int userScore = 0;
            int computerScore = 0;

            bool winner = false;
            bool check = false;

            
                do
            {           
            Console.WriteLine("This is \"Rock, paper, scissors \" game.");
            Console.WriteLine("(1) - Paper");
            Console.WriteLine("(2) - Rock");
            Console.WriteLine("(3) - Scissors");
            Console.WriteLine("Make a choice : ");

            string userInput = Console.ReadLine();
            var computerInput = (Choice)rndChoice.Next(1, 4);
            
            //  WYJĄTKI
            try
            {
                int user = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong answer. Please enter one of the number's from the menu above.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose the one of the option from the menu above.");
                Console.ForegroundColor = ConsoleColor.White;
                    continue;               
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("your argument is out of range.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("choose the one of the option from the menu above.");
                Console.ForegroundColor = ConsoleColor.White;
                    continue;                
            }

                if (int.Parse(userInput) > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your argument is out of range.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose the one of the option from the menu above.");
                Console.ForegroundColor = ConsoleColor.White;
                    continue;                
            }
            */
            /*
            if(check == true)
            {
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine($"Your choice : {(Choice)int.Parse(userInput)}");
                Console.WriteLine($"Computer choice : {computerInput}");
            }        
            */
            /*
            if(int.Parse(userInput) == 1 && computerInput == Choice.Rock || int.Parse(userInput) == 2 && computerInput == Choice.Scissors || int.Parse(userInput) == 3 && computerInput == Choice.Paper)
            {
                userScore++;
                Console.WriteLine("{0} beats {1}. User get's point." ,(Choice)int.Parse(userInput), computerInput);
                Console.WriteLine($"User score: {userScore}");
                Console.WriteLine($"Computer score: {computerScore}");
            }
            else if(int.Parse(userInput) == 1 && computerInput == Choice.Scissors || int.Parse(userInput) == 2 && computerInput == Choice.Paper || int.Parse(userInput) == 3 && computerInput == Choice.Rock)
            {
                computerScore++;
                Console.WriteLine("{0} beats {1}. Computer get's point.", computerInput, (Choice)int.Parse(userInput));
                Console.WriteLine($"User score: {userScore}");
                Console.WriteLine($"Computer score: {computerScore}");
            }
            else if(int.Parse(userInput) == 1 && computerInput == Choice.Paper || int.Parse(userInput) == 2 && computerInput == Choice.Rock || int.Parse(userInput) == 3 && computerInput == Choice.Scissors)
            {
                Console.WriteLine("It's a draw. Go on, try again.");
            }
            
           if (userScore == 3)
           {
               winner = true;
           }
             
           else if(computerScore == 3)
           {
               winner = true;
           }
           
           } while (!winner);
           */
            /*
            char response;

            Console.WriteLine("Do you wanna play again? (Y)es || (N)o");
            response = Convert.ToChar(Console.ReadLine().ToUpper());

            if (response == 'Y')
            {
                Console.Clear();
                check = true;
            }
            else if (response == 'N')
            {
                check = false;
            }
            */
        }
    }
}
