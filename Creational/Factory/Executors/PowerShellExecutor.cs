namespace DesignPatterns.Creational.Factory.Executors
{
    internal class PowerShellExecutor : IExecutor
    {
        public void Execute()
        {
            Console.WriteLine("Powershell execution");
        }
    }
}
