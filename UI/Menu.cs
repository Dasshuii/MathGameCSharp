namespace MathGame.UI
{
    internal abstract class Menu
    {
        protected List<String> options;

        protected int startIndex = 0;

        public abstract void configure();

        public void show()
        {
            configure();

            for (int i = 0, size = options.Count; i < size; i++) 
            {
                Console.WriteLine($"[{startIndex}] {options[i]}");
            }

    }
}
