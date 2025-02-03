using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----Singleton Pattern----\n");
            SingletonProgram.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Prototype Pattern----\n");
            PrototypeProgram.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Factory Pattern----\n");
            FactoryProgram.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Abstract Factory Pattern----\n");
            AbstractFactoryProgram.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Builder Pattern----\n");
            BuilderProgram.Call();
            Console.WriteLine("---------------------------------------------------------");

        }
    }
}