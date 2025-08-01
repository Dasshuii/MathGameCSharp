using MathGame.Game;
using MathGame.Models;
using MathGame.Models.Enums;
using MathGame.UI;
using MathGame.Util;

namespace MathGame 
{ 
    internal class Program
    {
        public static void Main()
        {
            string name = Input.GetInput("Name: ");
            GameEngine game = new();
            Menu menu = new();
            GameRecord record = new();

            bool exit;
            do
            {
                Console.WriteLine("WELCOME TO MATH GAME");
                menu.GameModeMenu();
                int modeOpt = Input.GetNumberInput("Opt: ");

                if (modeOpt == 0) exit = true;

                Console.Clear();
                menu.DifficultyMenu();
                int difficultyOpt = Input.GetNumberInput("Opt: ");


                record = game.Start((GameMode)modeOpt, (Difficulty)difficultyOpt);
                exit = true;
            } while (!exit);

            record.Name = name;
            Console.WriteLine($"Congratulations {name} your score was {record.Score}");
        }
    }
}
