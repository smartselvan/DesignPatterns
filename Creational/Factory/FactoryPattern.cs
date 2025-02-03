using DesignPatterns.Creational.Factory.Executors;

namespace DesignPatterns.Creational.Factory
{
    public class FactoryPattern
    {
        public static void Call()
        {
            ExecutorFactory factory = new ExecutorFactory();

            IExecutor executorSQL = factory.GetExecutor(ExecutorType.SQL);
            executorSQL.Execute();

            IExecutor executorPowershell = factory.GetExecutor(ExecutorType.Powershell);
            executorPowershell.Execute();
        }
    }
}
