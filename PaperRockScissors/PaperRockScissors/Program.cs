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
        }
    }
}
