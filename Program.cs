using System;
using Game;

namespace RockPaperScissors
{
  class Program
    {
        static void Main(string[] args)
        {
            var rock = new Rock();
            var paper = new Paper();
            var scissors = new Scissors();
            var computerChoice = new ComputerChoice();
            var gameResults = new Result();
            bool wantingToPlay = true;
            while(wantingToPlay)
            {
                    Console.WriteLine(@"
ROCK PAPER OR SCISSORS, BABY

THROW YOUR BEST
PRESS 'R' FOR ROCK
PRESS 'P' FOR PAPER
PRESS 'S' FOR SCISSORS
                    ");
                    var choice = Console.ReadKey();
                    if(choice.Key == ConsoleKey.R){
                        var userResult = rock.Shoot();
                        var computerResult = computerChoice.Shoot();
                        Console.WriteLine($@"
YOU CHOSE {userResult}");
                        Console.WriteLine($"THE COMPUTER CHOSE {computerResult}");
                        Console.WriteLine(gameResults.GameResults(userResult, computerResult));
                    }
                    if(choice.Key == ConsoleKey.P){
                        var userResult = paper.Shoot();
                        var computerResult = computerChoice.Shoot();
                        Console.WriteLine($@"
YOU CHOSE {userResult}");
                        Console.WriteLine($"THE COMPUTER CHOSE {computerResult}");
                        Console.WriteLine(gameResults.GameResults(userResult, computerResult));
                    }
                    if(choice.Key == ConsoleKey.S){
                        var userResult = scissors.Shoot();
                        var computerResult = computerChoice.Shoot();
                        Console.WriteLine($@"
YOU CHOSE {userResult}");
                        Console.WriteLine($"THE COMPUTER CHOSE {computerResult}");
                        Console.WriteLine(gameResults.GameResults(userResult, computerResult));
                    }
                        
                    
            }
        }
    }
}
