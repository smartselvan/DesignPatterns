using DesignPatterns.Creational.Factory.Executors;

namespace DesignPatterns.Creational.Factory
{
    public class ExecutorFactory
    {
        public ExecutorFactory()
        {
        }
        public IExecutor GetExecutor(ExecutorType executorType)
        {
            IExecutor executor;
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
    public enum ExecutorType
    {
        SQL,
        Powershell,
        RestAPI
    }
}
