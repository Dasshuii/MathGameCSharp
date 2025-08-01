namespace MathGame.UI
{
    internal class Menu
    {
        public void GameModeMenu()
        {
            Console.WriteLine("[1] ADDITION");
            Console.WriteLine("[2] SUBTRACTION");
            Console.WriteLine("[3] MULTIPLICATION");
            Console.WriteLine("[4] DIVISION");
            Console.WriteLine("[5] RANDOM");
            Console.WriteLine("[0] EXIT");
        }

        public void DifficultyMenu()
        {
            Console.WriteLine("[1] EASY");
            Console.WriteLine("[2] MEDIUM");
            Console.WriteLine("[3] HARD");
        }
    }
}
