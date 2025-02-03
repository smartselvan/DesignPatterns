using DesignPatterns.Creational.AbstractFactory.ExecutorFactory;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Factory.Executors;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryPattern
    {
        public static void Call()
        {
            AbstractFactory abstractFactory = new AbstractFactory();
            IExecutorFactory localExecutorFactory = abstractFactory.GetExecutorFactory(ExecutorFactoryType.Local);
            IExecutor localSQLExcutor = localExecutorFactory.GetExecutor(ExecutorType.SQL);
            localSQLExcutor.Execute();

            IExecutorFactory remoteExecutorFactory = abstractFactory.GetExecutorFactory(ExecutorFactoryType.Remote);
            IExecutor remotePowerShellExecutor = remoteExecutorFactory.GetExecutor(ExecutorType.Powershell);
            remotePowerShellExecutor.Execute();

        }
    }
}
