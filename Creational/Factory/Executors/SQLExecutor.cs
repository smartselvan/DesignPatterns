namespace DesignPatterns.Creational.Factory.Executors
{
    internal class SQLExecutor : IExecutor
    {
        public void Execute()
        {
            Console.WriteLine("SQL Execution");
        }
    }
}
