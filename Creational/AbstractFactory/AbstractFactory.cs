using DesignPatterns.Creational.AbstractFactory.ExecutorFactory;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactory
    {
        public AbstractFactory() { }
        public IExecutorFactory GetExecutorFactory(ExecutorFactoryType executorFactoryType)
        {
            IExecutorFactory executorFactory;
            switch (executorFactoryType)
            {
                case ExecutorFactoryType.Local:
                    executorFactory = new LocalExecutorFactory();
                    break;
                case ExecutorFactoryType.Remote:
                    executorFactory = new RemoteExecutorFactory();
                    break;
                default:
                    executorFactory = new LocalExecutorFactory();
                    break;
            }
            return executorFactory;
        }
    }

    public enum ExecutorFactoryType
    {
        Local,
        Remote
    }
}
