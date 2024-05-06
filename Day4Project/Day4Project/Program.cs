using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class RockPaperScissors
{
    public static void Main(string[] args)
    {

        bool replay = true;
        while (replay)
        {

            Console.WriteLine("Player1,Pick one:\n(rock,paper or scissors) ");
            string? player1 = Console.ReadLine();
            Console.WriteLine("Player 2, Pick one:\n(rock, paper or scissors)");
            string? player2 = Console.ReadLine();

            const string Rock = "rock";
            const string Scissors = "scissors";
            const string Paper = "paper";

            Console.WriteLine($"Player 1 picked {player1}\nPlayer2 picked {player2}");

            switch (player1)
            {
                case Rock:
                    if (player2 == Scissors)
                    { Console.WriteLine("Player 1 Wins"); }
                    else if (player2 == Rock)
                    { Console.WriteLine("It is a Draw"); }
                    else
                    { Console.WriteLine("Player 2 Wins"); }
                    break;

                case Scissors:
                    if (player2 == Scissors)
                    { Console.WriteLine("It is a Draw"); }
                    else if (player2 == Rock)
                    { Console.WriteLine("Player 2 Wins"); }
                    else
                    { Console.WriteLine("Player 1 Wins"); }
                    break;

                case Paper:
                    if (player2 == Scissors)
                    { Console.WriteLine("Player 2 Wins"); }
                    else if (player2 == Rock)
                    { Console.WriteLine("Player 1 Wins"); }
                    else
                    { Console.WriteLine("It is a Draw"); }
                    break;
            }

            Console.WriteLine("Would you like to play again?\ny or n");
            string? userReplay = Console.ReadLine();
            if (userReplay == "n")
                replay = false;

        }


    }
}


