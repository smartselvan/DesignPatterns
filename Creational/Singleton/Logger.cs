namespace DesignPatterns.Creational.Singleton
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _logger = new Lazy<Logger>(() => new Logger());
        public static Logger Instance => _logger.Value;

        private static int counter;
        private Logger()
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
        }
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
