using MathGame.Models;
using MathGame.Models.Enums;
using MathGame.Util;

namespace MathGame 
{ 
    internal class Program
    {
        public static void Main()
        {
            string name = Input.GetInput("Name: ");
            Game game = new Game();
            GameRecord record = game.Start(GameMode.ADDITION, Difficulty.EASY);
            record.Name = name;
            Console.WriteLine($"Congratulations {name} your score was {record.Score}");
        }
    }
}
