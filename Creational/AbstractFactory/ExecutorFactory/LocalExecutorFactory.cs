using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Factory.Executors;

namespace DesignPatterns.Creational.AbstractFactory.ExecutorFactory
{
    public class LocalExecutorFactory : IExecutorFactory
    {
        public IExecutor GetExecutor(ExecutorType executorType)
        {
            IExecutor executor;
            Console.WriteLine("Executors created from Local factory");
            switch (executorType)
            {
                case ExecutorType.SQL:
                    executor = new SQLExecutor();
                    break;
                case ExecutorType.Powershell:
                    executor = new PowerShellExecutor();
                    break;
                case ExecutorType.RestAPI:
                    executor = new RestAPIExecutor();
                    break;
                default:
                    executor = new RestAPIExecutor();
                    break;
            }
            return executor;
        }
    }
}
