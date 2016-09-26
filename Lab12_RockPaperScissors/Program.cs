using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors

{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesPlayed = 0;

        Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.WriteLine("Enter your name:");
            string playerName = Console.ReadLine();
            string rpsChosen;
            string playAgain;



            Console.WriteLine("\n");

            Console.WriteLine("Would you like to play against The Jets or The Sharks( Enter j or s)?\n");
            string chosenOpponent = Console.ReadLine();
            Console.WriteLine("\n");

            Player opponent = null;
            string opponentRockJet = "";
            do
            {
                if (chosenOpponent == "j")
                { opponent = new PlayerRock();
                    opponentRockJet="The Jets";}
                else { opponent = new PlayerRandom();
                    opponentRockJet = "The Sharks";
                }

                Roshambo opponentChoice = opponent.generateRoshambo();
                string playerChosenWord = "";
               



                Console.WriteLine("Let's Play!\n Choose (R)ock, (P)aper or (S)cissors!\n");
                    rpsChosen = Console.ReadLine();
                switch (rpsChosen.ToLower())
                {
                    case "r":
                        playerChosenWord = "Rock";
                        break;
                    case "p":
                        playerChosenWord = "Paper";
                        break;
                    case "s":
                        playerChosenWord = "Scissors";
                        break;
                    default:
                        break;
                }


                if ((rpsChosen == "r" && opponentChoice == Roshambo.Rock)||
                    (rpsChosen == "p" && opponentChoice == Roshambo.Paper)||
                    (rpsChosen == "s" && opponentChoice == Roshambo.Scissors))
                    {
                        Console.WriteLine(playerName + " "+ playerChosenWord);
                        Console.WriteLine(opponentRockJet + ": " + opponentChoice);
                        Console.WriteLine("Draw!");
                    }
                    if (rpsChosen == "p" && opponentChoice == Roshambo.Rock)
                    {
                        Console.WriteLine(playerName + " " + playerChosenWord);
                    Console.WriteLine(opponentRockJet + ": " + opponentChoice);
                        Console.WriteLine(playerName + " Wins!");
                    }

                    if (rpsChosen == "s" && opponentChoice == Roshambo.Paper)
                    {
                        Console.WriteLine(playerName + " " + playerChosenWord);
                        Console.WriteLine(opponentRockJet + ": " + opponentChoice);
                        Console.WriteLine(playerName +  " Wins!");
                    }

                    if (rpsChosen == "r" && opponentChoice == Roshambo.Paper)

                {
                    Console.WriteLine(playerName + " " + playerChosenWord);
                    Console.WriteLine(opponentRockJet + ": " + opponentChoice);
                    Console.WriteLine(opponentRockJet + " Wins!");
                }

                if (rpsChosen == "p" && opponentChoice == Roshambo.Scissors)

                {
                    Console.WriteLine(playerName + " " + playerChosenWord);
                    Console.WriteLine(opponentRockJet + ": " + opponentChoice);
                    Console.WriteLine(opponentRockJet + " Wins!");
                }


                if (rpsChosen == "s" && opponentChoice == Roshambo.Rock)

                {
                    Console.WriteLine(playerName + " " + playerChosenWord);
                    Console.WriteLine(opponentRockJet + ": " + opponentChoice);
                    Console.WriteLine(opponentRockJet + " Wins!");
                }



                Console.WriteLine("Play Again?(y/n)");
                    playAgain = Console.ReadLine();

                } while (playAgain == "y") ;
            
           

        }
    }
}
