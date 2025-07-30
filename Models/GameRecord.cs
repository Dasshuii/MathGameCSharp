using MathGame.Models.Enums;

namespace MathGame.Models
{
    internal class GameRecord
    {
        public string? Name { get; set; }
        public int Score { get; set; }
        public GameMode Mode {  get; set; }
        public Difficulty Difficulty { get; set; }
        public int TimeInSeconds { get; set; }
    }
}
