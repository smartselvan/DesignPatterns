namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton? instance;
        private static int counter;
        private static object lockObject = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}