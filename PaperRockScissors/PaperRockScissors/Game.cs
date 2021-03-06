﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaperRockScissors
{   
    
    class Game
    {
        //Lista opcji do wyboru
        enum Choice
        {
            Paper = 1,
            Rock = 2,
            Scissors = 3
        }

        public int userScore = 0;
        public int computerScore = 0;

        public bool winner = false;

        public void Play()
        {
            Screen();
            GameLogic();
        }
        public void Screen()
        {

            //Startowy ekran wyboru

            Console.WriteLine("This is \"Rock, paper, scissors \" game. Let's play!");
            Console.WriteLine("(1) - Paper");
            Console.WriteLine("(2) - Rock");
            Console.WriteLine("(3) - Scissors");
            Console.WriteLine("Make a choice (choose a number): ");
        }

        public void GameLogic()
        {

            //Lista wiadomości zwrotnych dla gracza

            List<string> message = new List<string>();
            message.Add("User gets point!");
            message.Add("Computer gets point!");
            message.Add("It's a draw. Go on, try again.");
            message.Add("User wins the Game!");
            message.Add("Computer wins the Game!");

            Random rndChoice = new Random();

            //Pętla wykonująca główną logike gry

            do
            {
                string userInput = Console.ReadLine();
                var computerInput = (Choice)rndChoice.Next(1, 4);

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

                if (int.Parse(userInput) == 1 && computerInput == Choice.Rock || int.Parse(userInput) == 2 && computerInput == Choice.Scissors || int.Parse(userInput) == 3 && computerInput == Choice.Paper)
                {
                    userScore++;
                    if (userScore == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0} beats {1}. User scores the last point.", (Choice)int.Parse(userInput), computerInput);
                        Console.WriteLine(message[3]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {                       
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0} beats {1}. ", (Choice)int.Parse(userInput), computerInput);
                        Console.WriteLine(message[0]);
                        Console.WriteLine($"User score: {userScore}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Computer score: {computerScore}");
                        Console.WriteLine(' ');
                        Console.WriteLine("(1) - Paper");
                        Console.WriteLine("(2) - Rock");
                        Console.WriteLine("(3) - Scissors");
                        Console.WriteLine("Make a selection: ");
                    }
                }
                else if (int.Parse(userInput) == 1 && computerInput == Choice.Scissors || int.Parse(userInput) == 2 && computerInput == Choice.Paper || int.Parse(userInput) == 3 && computerInput == Choice.Rock)
                {
                    computerScore++;
                    if (computerScore == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} beats {1}. Computer scores the last point.", computerInput, (Choice)int.Parse(userInput));
                        Console.WriteLine(message[4]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} beats {1}. ", computerInput, (Choice)int.Parse(userInput));
                        Console.WriteLine(message[1]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"User score: {userScore}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Computer score: {computerScore}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(' ');
                        Console.WriteLine("(1) - Paper");
                        Console.WriteLine("(2) - Rock");
                        Console.WriteLine("(3) - Scissors");
                        Console.WriteLine("Make a selection:");
                    }
                }
                else if (int.Parse(userInput) == 1 && computerInput == Choice.Paper || int.Parse(userInput) == 2 && computerInput == Choice.Rock || int.Parse(userInput) == 3 && computerInput == Choice.Scissors)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message[2]);
                    Console.WriteLine($"User score: {userScore}");
                    Console.WriteLine($"Computer score: {computerScore}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(' ');
                    Console.WriteLine("(1) - Paper");
                    Console.WriteLine("(2) - Rock");
                    Console.WriteLine("(3) - Scissors");
                    Console.WriteLine("Make a selection:");
                }
                
                if (userScore == 3)
                {
                    winner = true;
                }
                else if (computerScore == 3)
                {
                    winner = true;
                }         
                
            }while (!winner);
        }
    }
}
