using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Factory.Executors;

namespace DesignPatterns.Creational.AbstractFactory.ExecutorFactory
{
    public interface IExecutorFactory
    {
        IExecutor GetExecutor(ExecutorType executorType);
    }
}
