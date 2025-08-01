using MathGame.Models;
using MathGame.Models.Enums;
using MathGame.Util;
using System.Diagnostics;

namespace MathGame.Game
{
    internal class GameEngine
    {
        private const int ATTEMPTS = 5;
        private readonly Stopwatch stopwatch = new();
        private readonly QuestionGenerator questionGenerator = new();

        public GameRecord Start(GameMode gameMode, Difficulty difficulty)
        {
            int score = 0;

            stopwatch.Restart();
            stopwatch.Start();
            for (int i = 0; i < ATTEMPTS; i++)
            {
                Question question = questionGenerator.GenerateQuestion(gameMode, difficulty);
                int answer = Input.GetNumberInput(question.Text);

                if (answer == question.Answer)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else Console.WriteLine("Incorrect :(");
            }
            stopwatch.Stop();
            return new GameRecord { Score = score, Mode = gameMode, Difficulty = difficulty, TimeInSeconds = stopwatch.Elapsed.Seconds };
        }
    }
}
