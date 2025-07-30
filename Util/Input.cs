namespace MathGame.Util
{
    internal class Input
    {
        public static string GetInput(string prompt)
        {
            while (true) 
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) return input;
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        public static int GetNumberInput(string prompt)
        {
            while (true)
            {
                string input = GetInput(prompt);
                if (int.TryParse(input, out int number)) return number;
                Console.WriteLine("Please enter a number.");
            }
        }
    }
}
