using System;
namespace TheGame
{
    public class RockScissors
    {
        static void Main()
        {

            Game newGame = new Game();
            Console.WriteLine("Welcome to Rock, Paper, Scissors");
            Console.WriteLine("Player 1 please choose your weapon (Enter: Rock, Paper or Scissors)");
            newGame.SetPlayerOneChoice(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Player 2 please choose your weapon (Enter: Rock, Paper or Scissors)");
            newGame.SetPlayerTwoChoice(Console.ReadLine());
            newGame.SetWinner();
            Console.Clear();
            Console.WriteLine(newGame.GetGameWinner());
            Main();
        }
    }
}