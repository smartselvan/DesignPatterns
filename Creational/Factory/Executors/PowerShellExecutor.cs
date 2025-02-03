namespace DesignPatterns.Creational.Factory.Executors
{
    public class PowerShellExecutor : IExecutor
    {
        public void Execute()
        {
            Console.WriteLine("Powershell execution");
        }
    }
}
