using MathGame.Models;
using MathGame.Models.Enums;
using MathGame.Util;
using System.Diagnostics;

namespace MathGame
{
    internal class Game
    {
        private const int ATTEMPTS = 5;
        private readonly Random random = new();
        private readonly Stopwatch stopwatch = new();

        public GameRecord Start(GameMode gameMode, Difficulty difficulty)
        {
            int score = 0;

            stopwatch.Restart();
            stopwatch.Start();
            for (int i = 0; i < ATTEMPTS; i++)
            {
                int num1 = GetRandomNumber();
                int num2 = GetRandomNumber();
                char operation = GetOperation(gameMode);

                string question = $"{num1} {operation} {num2} = ";
                int answer = Input.GetNumberInput(question);

                if (answer == GetResult(operation, num1, num2))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
            }
            stopwatch.Stop();
            return new GameRecord { Score =  score, Mode = gameMode, Difficulty = difficulty, TimeInSeconds = stopwatch.Elapsed.Seconds };
        }

        public int GetRandomNumber() => random.Next(0, 11);
        public char GetOperation(GameMode gameMode)
        {
            return gameMode switch
            {
                GameMode.ADDITION => '+',
                GameMode.SUBTRACTION => '-',
                GameMode.MULTIPLICATION => '*',
                GameMode.DIVISION => '/',
                GameMode.RANDOM => "+-*/"[random.Next(0, 4)],
                _ => '+'
            };
        }

        public int GetResult(char operation, int num1, int num2)
        {
            return operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num1 / num2,
                _ => 0,
            };
        }

    }
}
