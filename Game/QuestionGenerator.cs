using MathGame.Models;
using MathGame.Models.Enums;
using System;

namespace MathGame.Game
{
    internal class QuestionGenerator
    {
        private readonly Random random = new();
        public Question GenerateQuestion(GameMode gameMode, Difficulty difficulty)
        {
            char operation = GetOperation(gameMode);
            int num1 = GetRandomNumber(difficulty);
            int num2 = gameMode == GameMode.DIVISION ? GenerateDivisor(num1) : GetRandomNumber(difficulty);

            return new Question(string.Format("{0} {1} {2} = ", num1, operation, num2), GetResult(operation, num1, num2));
        }

        private char GetOperation(GameMode gameMode)
        {
            return gameMode switch
            {
                GameMode.ADDITION => '+',
                GameMode.SUBTRACTION => '-',
                GameMode.MULTIPLICATION => '*',
                GameMode.DIVISION => '/',
                GameMode.RANDOM => "+-*/"[random.Next(0, 4)],
                _ => throw new Exception("Invalid ENUM value."),
            };
        }

        private int GetRandomNumber(Difficulty difficulty) 
        {
            return difficulty switch
            {
                Difficulty.EASY => random.Next(0, 10),
                Difficulty.MEDIUM => random.Next(10, 50),
                Difficulty.HARD => random.Next(50, 100),
                _ => throw new Exception("Invalid ENUM value."),
            };
        }

        private int GenerateDivisor(int num1)
        {
            int divisor = random.Next(num1 + 1);
            while (divisor == 0 || num1 % divisor != 0)
                divisor = random.Next(num1 + 1);
            return divisor;
        }

        private int GetResult(char operation, int num1, int num2)
        {
            return operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num1 / num2,
                _ => throw new Exception("Invalid operation."),
            };
        }
    }
}
